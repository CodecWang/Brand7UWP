using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace Brand7.Models
{
    class BrandHelper
    {
        public ObservableCollection<BrandModel> BrandList;
        private ObservableCollection<BrandModel> _AllBrands;
        private StorageFolder _LocalFolder;

        public BrandHelper()
        {
            _LocalFolder = ApplicationData.Current.LocalFolder;
            _AllBrands = new ObservableCollection<BrandModel>();
            BrandList = new ObservableCollection<BrandModel>();
        }

        /// <summary>
        /// 第一次启动APP时，初始化本地Json文件
        /// </summary>
        /// <returns></returns>
        public async Task FirstStartInitDataAsync()
        {
            StorageFile dataJsonFile = await _LocalFolder.CreateFileAsync("Brand7DataSource.json", CreationCollisionOption.ReplaceExisting);

            string originalStrJson = JSONHelper.GetOriginalJson();
            await FileIO.WriteTextAsync(dataJsonFile, originalStrJson);
        }

        /// <summary>
        /// 获取全部品牌列表
        /// </summary>
        /// <returns></returns>
        public async Task GetAllBrandsAsync()
        {
            BrandList.Clear();

            List<BrandModel> allBrands = new List<BrandModel>();
            allBrands = await ReadBrandsFromLocalAsync();

            foreach (var brand in allBrands)
            {
                brand.Image = string.Format("Assets/Images/{0}/{1}.jpg", brand.Category, brand.Name);
                BrandList.Add(brand);
                _AllBrands.Add(brand);
            }
        }

        /// <summary>
        /// 通过品牌类别来获取品牌列表
        /// </summary>
        /// <param name="category">品牌类别</param>
        public void GetBrandsByCategory(BrandCategory category)
        {
            BrandList.Clear();

            if (category == BrandCategory.All)
            {
                _AllBrands.ToList().ForEach(p => BrandList.Add(p));
            }

            var filter = _AllBrands.Where(p => p.Category == category.ToString()).ToList();
            filter.ForEach(p => BrandList.Add(p));
        }

        /// <summary>
        /// 将全部品牌列表写入本地文件
        /// </summary>
        /// <param name="brandList">品牌数据</param>
        public async Task WriteBrandsToLocalAsync()
        {
            StorageFile jsonFile = await _LocalFolder.GetFileAsync("Brand7DataSource.json");

            var serializer = new DataContractJsonSerializer(typeof(List<BrandModel>));
            var stream = new MemoryStream();
            serializer.WriteObject(stream, _AllBrands);

            byte[] dataBytes = new byte[stream.Length];
            stream.Position = 0;
            stream.Read(dataBytes, 0, (int)stream.Length);
            string strJson = Encoding.UTF8.GetString(dataBytes);

            await FileIO.WriteTextAsync(jsonFile, strJson);
        }

        /// <summary>
        /// 从本地文件中读入全部品牌列表
        /// </summary>
        /// <returns></returns>
        private async Task<List<BrandModel>> ReadBrandsFromLocalAsync()
        {
            List<BrandModel> all = new List<BrandModel>();
            StorageFile jsonFile = await _LocalFolder.GetFileAsync("Brand7DataSource.json");

            string json = await FileIO.ReadTextAsync(jsonFile);
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
            var serializer = new DataContractJsonSerializer(typeof(List<BrandModel>));
            all = (List<BrandModel>)serializer.ReadObject(ms);

            return all;
        }
    }
}
