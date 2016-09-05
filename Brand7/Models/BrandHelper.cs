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
        private ObservableCollection<BrandModel> _AllBrands;
        private StorageFolder _LocalFolder;
        ApplicationDataContainer localSettings;


        public BrandHelper()
        {
            _LocalFolder = ApplicationData.Current.LocalFolder;
            _AllBrands = new ObservableCollection<BrandModel>();
            localSettings = ApplicationData.Current.LocalSettings;
        }

        /// <summary>
        /// 第一次启动APP时，初始化本地Json文件
        /// </summary>
        /// <returns></returns>
        public async Task FirstStartInitDataAsync()
        {
            StorageFile dataJsonFile = await _LocalFolder.CreateFileAsync("Brand7DataSource.json", CreationCollisionOption.ReplaceExisting);

            string originalStrJson = @"[{""ID"":1,""Name"":""Adobe"",""Country"":""美国"",""Category"":""Technology"",""Tip"":""图像元老Photoshop的开发商""},{""ID"":2,""Name"":""Cherry"",""Country"":""德国"",""Category"":""Technology"",""Tip"":""全球数一数二的专业键盘制造厂商，以机械键盘闻名世界""},{""ID"":3,""Name"":""DC"",""Country"":""美国"",""Category"":""AudioOrVedio"",""Tip"":""美国漫画巨头之一，创造出世界上第一位超级英雄——超人""},{""ID"":4,""Name"":""IBM"",""Country"":""美国"",""Category"":""Technology"",""Tip"":""全球最大的信息技术和业务解决方案公司""},{""ID"":5,""Name"":""LG"",""Country"":""韩国"",""Category"":""Technology"",""Tip"":""韩国电子业第二大集团""},{""ID"":6,""Name"":""QQ"",""Country"":""中国"",""Category"":""Technology"",""Tip"":""腾讯出品，中国用户数量最多的社交软件""},{""ID"":7,""Name"":""阿里巴巴"",""Country"":""中国"",""Category"":""Technology"",""Tip"":""创始人马云""},{""ID"":8,""Name"":""艾德熊"",""Country"":""美国"",""Category"":""Cater"",""Tip"":""创造出了“乐啤露”极富天然成分的饮料""},{""ID"":9,""Name"":""爱奇艺"",""Country"":""中国"",""Category"":""Technology"",""Tip"":""中国视频网站，口号“悦享品质”""},{""ID"":10,""Name"":""安卓"",""Country"":""美国"",""Category"":""Technology"",""Tip"":""Google公司开发的移动操作系统""},{""ID"":11,""Name"":""奥林巴斯"",""Country"":""日本"",""Category"":""Technology"",""Tip"":""在日本第一次成功地将显微镜商品化""},{""ID"":12,""Name"":""百度"",""Country"":""中国"",""Category"":""Technology"",""Tip"":""全球最大的中文搜索引擎、最大的中文网站""},{""ID"":13,""Name"":""百胜"",""Country"":""美国"",""Category"":""Cater"",""Tip"":""全球最大的餐饮集团""},{""ID"":14,""Name"":""棒约翰"",""Country"":""美国"",""Category"":""Cater"",""Tip"":""世界三大披萨品牌之一，Better Ingredients，Better pizza！""},{""ID"":15,""Name"":""必胜客"",""Country"":""美国"",""Category"":""Cater"",""Tip"":""世界第一大披萨品牌""},{""ID"":16,""Name"":""必胜宅急送"",""Country"":""中国"",""Category"":""Cater"",""Tip"":""百胜（中国）的必胜客衍生的独立品牌""},{""ID"":17,""Name"":""宾得"",""Country"":""日本"",""Category"":""Technology"",""Tip"":""曾是旭光学公司的单反相机品牌""},{""ID"":18,""Name"":""冰雪皇后"",""Country"":""美国"",""Category"":""Cater"",""Tip"":""世界最大软冰淇淋销售商""},{""ID"":19,""Name"":""达美乐"",""Country"":""美国"",""Category"":""Cater"",""Tip"":""世界三大披萨品牌之一""},{""ID"":20,""Name"":""大润发"",""Country"":""中国"",""Category"":""Life"",""Tip"":""RT-MART，台湾大型连锁量贩店""},{""ID"":21,""Name"":""戴尔"",""Country"":""美国"",""Category"":""Technology"",""Tip"":""口号：The power to do more(激发无限) ""},{""ID"":22,""Name"":""德克士"",""Country"":""中国"",""Category"":""Cater"",""Tip"":""中国西式快餐特许加盟第一品牌""},{""ID"":23,""Name"":""德州仪器"",""Country"":""美国"",""Category"":""Technology"",""Tip"":""世界上最大的模拟电路技术部件制造商""},{""ID"":24,""Name"":""迪士尼"",""Country"":""美国"",""Category"":""AudioOrVedio"",""Tip"":""创造了“米老鼠”这一举世闻名的动画形象""},{""ID"":25,""Name"":""中国电信"",""Country"":""中国"",""Category"":""Technology"",""Tip"":""中国三大运营商之一，旗下有“天翼”品牌""},{""ID"":26,""Name"":""东方既白"",""Country"":""中国"",""Category"":""Cater"",""Tip"":""百胜旗下第一个中式餐饮品牌""},{""ID"":27,""Name"":""东芝"",""Country"":""日本"",""Category"":""Technology"",""Tip"":""日本最大的半导体制造商""},{""ID"":28,""Name"":""二十世纪福克斯"",""Country"":""美国"",""Category"":""AudioOrVedio"",""Tip"":""好莱坞八大电影公司之一，发行过“星球大战”""},{""ID"":29,""Name"":""飞利浦"",""Country"":""荷兰"",""Category"":""Technology"",""Tip"":""来自荷兰的世界知名电子品牌""},{""ID"":30,""Name"":""飞思卡尔"",""Country"":""美国"",""Category"":""Technology"",""Tip"":""全球领先的半导体公司，赞助举办有以其品牌命名的全国大学生智能车竞赛""},{""ID"":31,""Name"":""飞信"",""Country"":""中国"",""Category"":""Technology"",""Tip"":""中国移动推出的综合通信服务""},{""ID"":32,""Name"":""高通"",""Country"":""美国"",""Category"":""Technology"",""Tip"":""无线电通信技术研发公司，目前使用最多的智能手机处理器厂商""},{""ID"":33,""Name"":""高通骁龙"",""Country"":""美国"",""Category"":""Technology"",""Tip"":""Qualcomm旗下移动处理器和LTE调制解调器的品牌名""},{""ID"":34,""Name"":""哥伦比亚"",""Country"":""美国"",""Category"":""AudioOrVedio"",""Tip"":""好莱坞八大电影公司之一，目前属索尼旗下""},{""ID"":35,""Name"":""工商银行"",""Country"":""中国"",""Category"":""Life"",""Tip"":""中国五大银行之首""},{""ID"":36,""Name"":""谷歌"",""Country"":""美国"",""Category"":""Technology"",""Tip"":""旗下拥有全球最大的搜索引擎""},{""ID"":37,""Name"":""哈佛"",""Country"":""美国"",""Category"":""University"",""Tip"":""美国本土历史最悠久的高等学府""},{""ID"":38,""Name"":""哈根达斯"",""Country"":""美国"",""Category"":""Cater"",""Tip"":""风靡全球的冰淇淋品牌""},{""ID"":39,""Name"":""海思"",""Country"":""中国"",""Category"":""Technology"",""Tip"":""前身是华为集成电路设计中心""},{""ID"":40,""Name"":""海滋客"",""Country"":""美国"",""Category"":""Cater"",""Tip"":""国际连锁速食餐厅，以海鲜、炸鱼块为其主要特色""},{""ID"":41,""Name"":""汉堡王"",""Country"":""美国"",""Category"":""Cater"",""Tip"":""全球第二大快餐连锁企业""},{""ID"":42,""Name"":""好又多"",""Country"":""中国"",""Category"":""Life"",""Tip"":""中国大陆连锁分店数量最多的外资商业企业""},{""ID"":43,""Name"":""黑莓"",""Country"":""加拿大"",""Category"":""Technology"",""Tip"":""其手机产品往往配备有QWERTY全键盘""},{""ID"":44,""Name"":""黑人"",""Country"":""中国"",""Category"":""Life"",""Tip"":""一直被当作是国外的牙膏品牌""},{""ID"":45,""Name"":""宏达"",""Country"":""中国"",""Category"":""Technology"",""Tip"":""全球最大的智能手机代工和生产厂商""},{""ID"":46,""Name"":""宏碁"",""Country"":""中国"",""Category"":""Technology"",""Tip"":""全球第四大个人电脑制造商""},{""ID"":47,""Name"":""华纳兄弟"",""Country"":""美国"",""Category"":""AudioOrVedio"",""Tip"":""好莱坞八大电影公司之一，创造了007经典影视形象""},{""ID"":48,""Name"":""华润万家"",""Country"":""中国"",""Category"":""Life"",""Tip"":""华润旗下的零售连锁企业品牌""},{""ID"":49,""Name"":""华硕"",""Country"":""中国"",""Category"":""Technology"",""Tip"":""全球第一大主板生产商""},{""ID"":50,""Name"":""华为"",""Country"":""中国"",""Category"":""Technology"",""Tip"":""旗下有互联网手机品牌“荣耀”""},{""ID"":51,""Name"":""环球影业"",""Country"":""美国"",""Category"":""AudioOrVedio"",""Tip"":""好莱坞八大电影公司之一，曾出品过“侏罗纪公园”""},{""ID"":52,""Name"":""惠普"",""Country"":""美国"",""Category"":""Technology"",""Tip"":""世界最大的IT公司之一，曾收购康柏电脑""},{""ID"":53,""Name"":""技嘉"",""Country"":""中国"",""Category"":""Technology"",""Tip"":""台湾第二大专业主板制造商""},{""ID"":54,""Name"":""佳能"",""Country"":""日本"",""Category"":""Technology"",""Tip"":""占有率排名第一的相机品牌""},{""ID"":55,""Name"":""家乐福"",""Country"":""法国"",""Category"":""Life"",""Tip"":""欧洲第一大零售商""},{""ID"":56,""Name"":""建设银行"",""Country"":""中国"",""Category"":""Life"",""Tip"":""中国五大银行之一，缩写为CCB""},{""ID"":57,""Name"":""交通银行"",""Country"":""中国"",""Category"":""Life"",""Tip"":""中国近代以来延续历史最悠久、最古老的银行""},{""ID"":58,""Name"":""金龙鱼"",""Country"":""新加坡"",""Category"":""Life"",""Tip"":""世界500强丰益国际旗下著名粮油品牌""},{""ID"":59,""Name"":""金士顿"",""Country"":""美国"",""Category"":""Technology"",""Tip"":""全球最大的独立内存产品制造商""},{""ID"":60,""Name"":""京东"",""Country"":""中国"",""Category"":""Technology"",""Tip"":""中国第一个成功赴美上市的大型综合型电商平台""},{""ID"":61,""Name"":""卡西欧"",""Country"":""日本"",""Category"":""Technology"",""Tip"":""生产电子仪器、电子计算器为主，在中国以其计算器、手表闻名""},{""ID"":62,""Name"":""康师傅"",""Country"":""中国"",""Category"":""Cater"",""Tip"":""国内排名第一的方便面品牌，现属于顶新集团""},{""ID"":63,""Name"":""柯尼卡美能达"",""Country"":""日本"",""Category"":""Technology"",""Tip"":""在中国以大型打印机闻名，企业口号：“The essentials of imaging”""},{""ID"":64,""Name"":""肯德基"",""Country"":""美国"",""Category"":""Cater"",""Tip"":""世界第二大速食及最大炸鸡连锁企业""},{""ID"":65,""Name"":""莱卡"",""Country"":""德国"",""Category"":""Technology"",""Tip"":""产于德国的精良世界级相机品牌""},{""ID"":66,""Name"":""蓝天工作室"",""Country"":""美国"",""Category"":""AudioOrVedio"",""Tip"":""好莱坞著名动画工作室，出品有“冰河世纪”""},{""ID"":67,""Name"":""劳斯莱斯"",""Country"":""英国"",""Category"":""Car"",""Tip"":""世界顶级超豪华轿车厂商""},{""ID"":68,""Name"":""乐购"",""Country"":""英国"",""Category"":""Life"",""Tip"":""英国最大的零售公司，世界三大零售商之一""},{""ID"":69,""Name"":""雷蛇"",""Country"":""美国"",""Category"":""Technology"",""Tip"":""全球顶级游戏外设品牌，宗旨是：“始于玩家，赋予玩家” ""},{""ID"":70,""Name"":""联发科"",""Country"":""中国"",""Category"":""Technology"",""Tip"":""全球著名IC设计厂商，简称MTK""},{""ID"":71,""Name"":""联美"",""Country"":""美国"",""Category"":""AudioOrVedio"",""Tip"":""好莱坞八大电影公司之一，现东家为汤姆·克鲁斯""},{""ID"":72,""Name"":""中国联通"",""Country"":""中国"",""Category"":""Technology"",""Tip"":""中国唯一一家在纽约、香港、上海三地同时上市的电信运营企业""},{""ID"":73,""Name"":""联想"",""Country"":""中国"",""Category"":""Technology"",""Tip"":""其电脑销量位居中国首位，2013年超越惠普成为全球最大的PC生产厂商""},{""ID"":74,""Name"":""麦当劳"",""Country"":""美国"",""Category"":""Cater"",""Tip"":""世界第一大速食企业""},{""ID"":75,""Name"":""麦德龙"",""Country"":""德国"",""Category"":""Life"",""Tip"":""德国最大、欧洲第二的零售批发超市集团""},{""ID"":76,""Name"":""漫威"",""Country"":""美国"",""Category"":""AudioOrVedio"",""Tip"":""与DC起名的漫画巨头，旗下有蜘蛛侠，美国队长等漫画角色""},{""ID"":77,""Name"":""梦工厂"",""Country"":""美国"",""Category"":""AudioOrVedio"",""Tip"":""电影公司，创始人之一为史蒂文·斯皮尔伯格""},{""ID"":78,""Name"":""米高梅"",""Country"":""美国"",""Category"":""AudioOrVedio"",""Tip"":""好莱坞八大电影公司之一，发起并推出了奥斯卡奖""},{""ID"":79,""Name"":""摩托罗拉"",""Country"":""美国"",""Category"":""Technology"",""Tip"":""全球芯片制造、电子通讯的领导者，其移动业务先后被谷歌和联想收购""},{""ID"":80,""Name"":""耐克"",""Country"":""美国"",""Category"":""Fashion"",""Tip"":""全球著名的体育运动品牌，口号：“Just do it”""},{""ID"":81,""Name"":""尼康"",""Country"":""日本"",""Category"":""Technology"",""Tip"":""日本著名相机品牌，排名仅次于佳能""},{""ID"":82,""Name"":""农业银行"",""Country"":""中国"",""Category"":""Life"",""Tip"":""中国五大银行之一，缩写为ABC""},{""ID"":83,""Name"":""诺基亚"",""Country"":""芬兰"",""Category"":""Technology"",""Tip"":""曾是手机界的王者，后与微软合作Windows Phone手机""},{""ID"":84,""Name"":""欧尚"",""Country"":""法国"",""Category"":""Life"",""Tip"":""法国第二大以经营零售业为主的商业集团，全球十大零售商之一""},{""ID"":85,""Name"":""派拉蒙"",""Country"":""美国"",""Category"":""AudioOrVedio"",""Tip"":""好莱坞八大电影公司之一，群星环绕雪山为标志，代表作品有：“教父”""},{""ID"":86,""Name"":""皮克斯"",""Country"":""美国"",""Category"":""AudioOrVedio"",""Tip"":""顶级动画工作室，曾是卢卡斯电影公司的电脑动画部，现属迪士尼旗下""},{""ID"":87,""Name"":""苹果"",""Country"":""美国"",""Category"":""Technology"",""Tip"":""世界最具价值品牌，著名手机品牌为iphone""},{""ID"":88,""Name"":""奇虎"",""Country"":""中国"",""Category"":""Technology"",""Tip"":""创始人周鸿祎，特色产品有：安全卫士和杀毒软件""},{""ID"":89,""Name"":""去哪儿"",""Country"":""中国"",""Category"":""Technology"",""Tip"":""中文在线旅行网站，现与携程网合并""},{""ID"":90,""Name"":""全家"",""Country"":""日本"",""Category"":""Life"",""Tip"":""第一家由亚洲发起进入美国市场的便利店企业""},{""ID"":91,""Name"":""雀巢"",""Country"":""瑞士"",""Category"":""Cater"",""Tip"":""世界上最大的食品制造商，以生产巧克力棒和速溶咖啡闻名""},{""ID"":92,""Name"":""人人网"",""Country"":""中国"",""Category"":""Technology"",""Tip"":""中国类似Facebook的实名制社交网络平台""},{""ID"":93,""Name"":""日立"",""Country"":""日本"",""Category"":""Technology"",""Tip"":""日本的一家全球最大的综合跨国集团""},{""ID"":94,""Name"":""软银"",""Country"":""日本"",""Category"":""Technology"",""Tip"":""由孙正义成立的综合性的风险投资公司""},{""ID"":95,""Name"":""赛百味"",""Country"":""美国"",""Category"":""Cater"",""Tip"":""世界上扩张最快及最大单一品牌连锁店，主要贩售三明治和沙拉""},{""ID"":96,""Name"":""三星"",""Country"":""韩国"",""Category"":""Technology"",""Tip"":""韩国最大的跨国企业集团""},{""ID"":97,""Name"":""施乐"",""Country"":""美国"",""Category"":""Technology"",""Tip"":""全球最大数字与信息技术产品生产商，复印技术的发明公司""},{""ID"":98,""Name"":""松下"",""Country"":""日本"",""Category"":""Technology"",""Tip"":""世界500强，口号：“A Better Life A Better World”""},{""ID"":99,""Name"":""搜狐"",""Country"":""中国"",""Category"":""Technology"",""Tip"":""中国四大门户网站之一，创始人张朝阳""},{""ID"":100,""Name"":""索尼"",""Country"":""日本"",""Category"":""Technology"",""Tip"":""世界最早便携式数码产品的开创者""},{""ID"":101,""Name"":""塔可钟"",""Country"":""美国"",""Category"":""Cater"",""Tip"":""世界上规模最大的提供墨西哥式食品的连锁餐饮品牌""},{""ID"":102,""Name"":""唐恩都乐"",""Country"":""美国"",""Category"":""Cater"",""Tip"":""美国十大快餐连锁品牌之一，别名“当肯甜甜圈”""},{""ID"":103,""Name"":""腾讯"",""Country"":""中国"",""Category"":""Technology"",""Tip"":""中国四大门户网站之一，推出有QQ，微信等社交工具""},{""ID"":104,""Name"":""天猫"",""Country"":""中国"",""Category"":""Technology"",""Tip"":""原名淘宝商城，隶属于阿里巴巴旗下""},{""ID"":105,""Name"":""土豆网"",""Country"":""中国"",""Category"":""Technology"",""Tip"":""全球最早上线的视频网站之一，现与优酷合并""},{""ID"":106,""Name"":""外星人"",""Country"":""美国"",""Category"":""Technology"",""Tip"":""戴尔旗下高端游戏笔记本品牌""},{""ID"":107,""Name"":""网易"",""Country"":""中国"",""Category"":""Technology"",""Tip"":""中国四大门户网站之一，公司口号：“网聚人的力量”""},{""ID"":108,""Name"":""微软"",""Country"":""美国"",""Category"":""Technology"",""Tip"":""全球最大的电脑软件提供商，著名产品有Windows/Office""},{""ID"":109,""Name"":""微信"",""Country"":""中国"",""Category"":""Technology"",""Tip"":""亚洲最大用户群体的移动即时通讯软件，著名功能有“朋友圈”""},{""ID"":110,""Name"":""唯品会"",""Country"":""中国"",""Category"":""Technology"",""Tip"":""定位于“一家专门做特卖的网站”""},{""ID"":111,""Name"":""维基百科"",""Country"":""美国"",""Category"":""Technology"",""Tip"":""基于维基技术的全球性多语言百科全书""},{""ID"":112,""Name"":""味千拉面"",""Country"":""日本"",""Category"":""Cater"",""Tip"":""特色是拉面及日式美食""},{""ID"":113,""Name"":""味全"",""Country"":""中国"",""Category"":""Life"",""Tip"":""台湾知名综合食品企业，现属顶新集团""},{""ID"":114,""Name"":""沃尔玛"",""Country"":""美国"",""Category"":""Life"",""Tip"":""世界连锁企业，世界500强企业之首""},{""ID"":115,""Name"":""喜士多"",""Country"":""中国"",""Category"":""Life"",""Tip"":""便利店品牌之一，与大润发同属润泰集团""},{""ID"":116,""Name"":""小肥羊"",""Country"":""中国"",""Category"":""Cater"",""Tip"":""中国首家在香港上市的品牌餐饮企业，被誉为中华火锅第一股""},{""ID"":117,""Name"":""小米"",""Country"":""中国"",""Category"":""Technology"",""Tip"":""移动互联网公司，其产品概念为“为发烧而生”""},{""ID"":118,""Name"":""携程"",""Country"":""中国"",""Category"":""Technology"",""Tip"":""在线票务服务公司，标志物为海豚""},{""ID"":119,""Name"":""新浪"",""Country"":""中国"",""Category"":""Technology"",""Tip"":""四大综合门户网站之首""},{""ID"":120,""Name"":""星巴克"",""Country"":""美国"",""Category"":""Cater"",""Tip"":""全球最大的咖啡连锁店""},{""ID"":121,""Name"":""兄弟"",""Country"":""日本"",""Category"":""Technology"",""Tip"":""最初生产缝纫机，之后以打印机闻名""},{""ID"":122,""Name"":""许留山"",""Country"":""中国"",""Category"":""Cater"",""Tip"":""香港著名连锁式甜品店，以芒果为主要材料""},{""ID"":123,""Name"":""迅雷"",""Country"":""中国"",""Category"":""Technology"",""Tip"":""旗下有中国使用最多的下载软件""},{""ID"":124,""Name"":""亚马逊"",""Country"":""美国"",""Category"":""Technology"",""Tip"":""美国最大的一家网络电子商务公司""},{""ID"":125,""Name"":""中国移动"",""Country"":""中国"",""Category"":""Technology"",""Tip"":""中国三大运营商份额居首""},{""ID"":126,""Name"":""英特尔"",""Country"":""美国"",""Category"":""Technology"",""Tip"":""全球最大的个人计算机零件和CPU制造商""},{""ID"":127,""Name"":""英伟达"",""Country"":""美国"",""Category"":""Technology"",""Tip"":""全球著名IC半导体公司，其显卡俗称N卡""},{""ID"":128,""Name"":""永辉超市"",""Country"":""中国"",""Category"":""Life"",""Tip"":""中国十强连锁超市，创始人张轩松""},{""ID"":129,""Name"":""优酷"",""Country"":""中国"",""Category"":""Technology"",""Tip"":""中国领先的视频分享网站，曾于土豆网合并""},{""ID"":130,""Name"":""真功夫"",""Country"":""中国"",""Category"":""Cater"",""Tip"":""中国快餐行业前五强中唯一的本土品牌""},{""ID"":131,""Name"":""中国银行"",""Country"":""中国"",""Category"":""Life"",""Tip"":""中国五大银行之一，标志像一个“中”字""},{""ID"":132,""Name"":""中兴"",""Country"":""中国"",""Category"":""Technology"",""Tip"":""中国最大的通信设备上市公司""}]";
            await FileIO.WriteTextAsync(dataJsonFile, originalStrJson);
        }

        /// <summary>
        /// 获取全部品牌数据
        /// </summary>
        /// <param name="brandList">品牌数据</param>
        /// <returns></returns>
        public async Task GetAllBrandsAsync(ObservableCollection<BrandModel> brandList)
        {
            brandList.Clear();
            List<BrandModel> allBrands = new List<BrandModel>();

            allBrands = await ReadBrandsFromLocalAsync();

            foreach (var brand in allBrands)
            {
                brand.Image = string.Format("Assets/Images/{0}/{1}.jpg", brand.Category, brand.Name);
                brandList.Add(brand);
                _AllBrands.Add(brand);
            }
        }

        public void GetBrandsByCategory(ObservableCollection<BrandModel> brandList, BrandCategory category)
        {
            brandList.Clear();

            if (category == BrandCategory.None)
            {
                _AllBrands.ToList().ForEach(p => brandList.Add(p));
            }

            var filter = _AllBrands.Where(p => p.Category == category.ToString()).ToList();
            filter.ForEach(p => brandList.Add(p));
        }

        /// <summary>
        /// 将品牌数据写入本地文件
        /// </summary>
        /// <param name="brandList">品牌数据</param>
        public async void WriteBrandsToLocalAsync(ObservableCollection<BrandModel> brandList)
        {
            StorageFile jsonFile = await _LocalFolder.GetFileAsync("Brand7DataSource.json");

            var serializer = new DataContractJsonSerializer(typeof(List<BrandModel>));
            var stream = new MemoryStream();
            serializer.WriteObject(stream, brandList);

            byte[] dataBytes = new byte[stream.Length];
            stream.Position = 0;
            stream.Read(dataBytes, 0, (int)stream.Length);
            string strJson = Encoding.UTF8.GetString(dataBytes);

            await FileIO.WriteTextAsync(jsonFile, strJson);
        }

        /// <summary>
        /// 从本地文件中读入品牌数据
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
