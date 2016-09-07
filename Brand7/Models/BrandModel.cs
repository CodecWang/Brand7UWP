using System.Runtime.Serialization;
using System.ComponentModel;

namespace Brand7.Models
{
    [DataContract]
    class BrandModel : INotifyPropertyChanged
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string PlusName { get; set; }
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public string Category { get; set; }
        [DataMember]
        public int Grade { get; set; }
        [DataMember]
        public string Tip { get; set; }
        public string Image { get; set; }
        public bool IsSelected { get; set; }

        private bool _IsFinished;
        [DataMember]
        public bool IsFinished
        {
            get
            {
                return _IsFinished;
            }
            set
            {
                this._IsFinished = value;
                notifyPropertyChanged("IsFinished");
            }
        }
        private double _Size;
        public double Size
        {
            get
            {
                return this._Size;
            }
            set
            {
                this._Size = value;
                notifyPropertyChanged("Size");
            }
        }

        /// <summary>
        /// 实现INotifyPropertyChanged接口，通知绑定更新
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        public void notifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
