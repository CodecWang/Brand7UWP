namespace Brand7.Models
{
    class JSONHelper
    {
        public static string GetOriginalJson()
        {
            string json =
@"
[
  {
    ""ID"": 1,
    ""Name"": ""QQ"",
    ""PlusName"": ""-"",
    ""Country"": ""中国"",
    ""Category"": ""Tech"",
    ""Grade"": 1,
    ""Tip"": ""腾讯出品，中国用户数量最多的社交软件""
  },
  {
    ""ID"": 2,
    ""Name"": ""百度"",
    ""PlusName"": ""Baidu"",
    ""Country"": ""中国"",
    ""Category"": ""Tech"",
    ""Grade"": 1,
    ""Tip"": ""全球最大的中文搜索引擎、最大的中文网站""
  },
  {
    ""ID"": 3,
    ""Name"": ""必胜客"",
    ""PlusName"": ""PizzaHut"",
    ""Country"": ""美国"",
    ""Category"": ""Cater"",
    ""Grade"": 1,
    ""Tip"": ""世界第一大披萨品牌""
  },
  {
    ""ID"": 4,
    ""Name"": ""工商银行"",
    ""PlusName"": ""ICBC"",
    ""Country"": ""中国"",
    ""Category"": ""Lifestyle"",
    ""Grade"": 1,
    ""Tip"": ""中国五大银行之首""
  },
  {
    ""ID"": 5,
    ""Name"": ""京东"",
    ""PlusName"": ""JD"",
    ""Country"": ""中国"",
    ""Category"": ""Tech"",
    ""Grade"": 1,
    ""Tip"": ""中国第一个成功赴美上市的大型综合型电商平台""
  },
  {
    ""ID"": 6,
    ""Name"": ""肯德基"",
    ""PlusName"": ""KFC"",
    ""Country"": ""美国"",
    ""Category"": ""Cater"",
    ""Grade"": 1,
    ""Tip"": ""世界第二大速食及最大炸鸡连锁企业""
  },
  {
    ""ID"": 7,
    ""Name"": ""麦当劳"",
    ""PlusName"": ""McDonald\u0027s"",
    ""Country"": ""美国"",
    ""Category"": ""Cater"",
    ""Grade"": 1,
    ""Tip"": ""世界第一大速食企业""
  },
  {
    ""ID"": 8,
    ""Name"": ""耐克"",
    ""PlusName"": ""NIKE"",
    ""Country"": ""美国"",
    ""Category"": ""Fashion"",
    ""Grade"": 1,
    ""Tip"": ""\""全球著名的体育运动品牌，口号：\""\""Just do it\""\""\""""
  },
  {
    ""ID"": 9,
    ""Name"": ""苹果"",
    ""PlusName"": ""Apple"",
    ""Country"": ""美国"",
    ""Category"": ""Tech"",
    ""Grade"": 1,
    ""Tip"": ""世界最具价值品牌，著名手机品牌为iphone""
  },
  {
    ""ID"": 10,
    ""Name"": ""天猫"",
    ""PlusName"": ""Tmall"",
    ""Country"": ""中国"",
    ""Category"": ""Tech"",
    ""Grade"": 1,
    ""Tip"": ""原名淘宝商城，隶属于阿里巴巴旗下""
  },
  {
    ""ID"": 11,
    ""Name"": ""土豆网"",
    ""PlusName"": ""Tudou"",
    ""Country"": ""中国"",
    ""Category"": ""AV"",
    ""Grade"": 1,
    ""Tip"": ""全球最早上线的视频网站之一，现与优酷合并""
  },
  {
    ""ID"": 12,
    ""Name"": ""微信"",
    ""PlusName"": ""WeChat"",
    ""Country"": ""中国"",
    ""Category"": ""Tech"",
    ""Grade"": 1,
    ""Tip"": ""\""亚洲最大用户群体的移动即时通讯软件，著名功能有\""\""朋友圈\""\""\""""
  },
  {
    ""ID"": 13,
    ""Name"": ""优酷"",
    ""PlusName"": ""Youku"",
    ""Country"": ""中国"",
    ""Category"": ""AV"",
    ""Grade"": 1,
    ""Tip"": ""中国领先的视频分享网站，曾于土豆网合并""
  },
  {
    ""ID"": 14,
    ""Name"": ""奥迪"",
    ""PlusName"": ""Audi"",
    ""Country"": ""德国"",
    ""Category"": ""Car"",
    ""Grade"": 1,
    ""Tip"": ""大众旗下的豪华汽车品牌""
  },
  {
    ""ID"": 15,
    ""Name"": ""大众"",
    ""PlusName"": ""Volkswagen"",
    ""Country"": ""德国"",
    ""Category"": ""Car"",
    ""Grade"": 1,
    ""Tip"": ""世界四大汽车生产商之一，简称VW""
  },
  {
    ""ID"": 16,
    ""Name"": ""李宁"",
    ""PlusName"": ""LI-NING"",
    ""Country"": ""中国"",
    ""Category"": ""Fashion"",
    ""Grade"": 1,
    ""Tip"": ""\""中国\""\""体操王子\""\""以其姓名创立的运动品牌\""""
  },
  {
    ""ID"": 17,
    ""Name"": ""爱奇艺"",
    ""PlusName"": ""iQIYI?"",
    ""Country"": ""中国"",
    ""Category"": ""AV"",
    ""Grade"": 2,
    ""Tip"": ""\""中国视频网站，口号\""\""悦享品质\""\""\""""
  },
  {
    ""ID"": 18,
    ""Name"": ""必胜宅急送"",
    ""PlusName"": ""-"",
    ""Country"": ""中国"",
    ""Category"": ""Cater"",
    ""Grade"": 2,
    ""Tip"": ""百胜（中国）的必胜客衍生的独立品牌""
  },
  {
    ""ID"": 19,
    ""Name"": ""电信"",
    ""PlusName"": ""China Telecom"",
    ""Country"": ""中国"",
    ""Category"": ""Tech"",
    ""Grade"": 2,
    ""Tip"": ""\""中国三大运营商之一，旗下有\""\""天翼\""\""品牌\""""
  },
  {
    ""ID"": 20,
    ""Name"": ""东方既白"",
    ""PlusName"": ""-"",
    ""Country"": ""中国"",
    ""Category"": ""Cater"",
    ""Grade"": 2,
    ""Tip"": ""百胜旗下第一个中式餐饮品牌""
  },
  {
    ""ID"": 21,
    ""Name"": ""黑人"",
    ""PlusName"": ""DARLIE"",
    ""Country"": ""中国"",
    ""Category"": ""Lifestyle"",
    ""Grade"": 2,
    ""Tip"": ""一直被当作是国外的牙膏品牌""
  },
  {
    ""ID"": 22,
    ""Name"": ""宏碁"",
    ""PlusName"": ""acer"",
    ""Country"": ""中国"",
    ""Category"": ""Tech"",
    ""Grade"": 2,
    ""Tip"": ""全球第四大个人电脑制造商""
  },
  {
    ""ID"": 23,
    ""Name"": ""华硕"",
    ""PlusName"": ""ASUS"",
    ""Country"": ""中国"",
    ""Category"": ""Tech"",
    ""Grade"": 2,
    ""Tip"": ""全球第一大主板生产商""
  },
  {
    ""ID"": 24,
    ""Name"": ""佳能"",
    ""PlusName"": ""Canon"",
    ""Country"": ""日本"",
    ""Category"": ""Tech"",
    ""Grade"": 2,
    ""Tip"": ""占有率排名第一的相机品牌""
  },
  {
    ""ID"": 25,
    ""Name"": ""建设银行"",
    ""PlusName"": ""China Construction Bank"",
    ""Country"": ""中国"",
    ""Category"": ""Lifestyle"",
    ""Grade"": 2,
    ""Tip"": ""中国五大银行之一，缩写为CCB""
  },
  {
    ""ID"": 26,
    ""Name"": ""康师傅"",
    ""PlusName"": ""-"",
    ""Country"": ""中国"",
    ""Category"": ""Cater"",
    ""Grade"": 2,
    ""Tip"": ""国内排名第一的方便面品牌，现属于顶新集团""
  },
  {
    ""ID"": 27,
    ""Name"": ""联通"",
    ""PlusName"": ""China Unicom"",
    ""Country"": ""中国"",
    ""Category"": ""Tech"",
    ""Grade"": 2,
    ""Tip"": ""中国唯一一家在纽约、香港、上海三地同时上市的电信运营企业""
  },
  {
    ""ID"": 28,
    ""Name"": ""农业银行"",
    ""PlusName"": ""ABC"",
    ""Country"": ""中国"",
    ""Category"": ""Lifestyle"",
    ""Grade"": 2,
    ""Tip"": ""中国五大银行之一，缩写为ABC""
  },
  {
    ""ID"": 29,
    ""Name"": ""诺基亚"",
    ""PlusName"": ""Nokia"",
    ""Country"": ""芬兰"",
    ""Category"": ""Tech"",
    ""Grade"": 2,
    ""Tip"": ""曾是手机界的王者，后与微软合作Windows Phone手机""
  },
  {
    ""ID"": 30,
    ""Name"": ""腾讯"",
    ""PlusName"": ""Tencent"",
    ""Country"": ""中国"",
    ""Category"": ""Tech"",
    ""Grade"": 2,
    ""Tip"": ""中国四大门户网站之一，推出有QQ，微信等社交工具""
  },
  {
    ""ID"": 31,
    ""Name"": ""小米"",
    ""PlusName"": ""MI"",
    ""Country"": ""中国"",
    ""Category"": ""Tech"",
    ""Grade"": 2,
    ""Tip"": ""\""移动互联网公司，其产品概念为\""\""为发烧而生\""\""\""""
  },
  {
    ""ID"": 32,
    ""Name"": ""星巴克"",
    ""PlusName"": ""Starbucks"",
    ""Country"": ""美国"",
    ""Category"": ""Cater"",
    ""Grade"": 2,
    ""Tip"": ""全球最大的咖啡连锁店""
  },
  {
    ""ID"": 33,
    ""Name"": ""迅雷"",
    ""PlusName"": ""Thunder"",
    ""Country"": ""中国"",
    ""Category"": ""Tech"",
    ""Grade"": 2,
    ""Tip"": ""旗下有中国使用最多的下载软件""
  },
  {
    ""ID"": 34,
    ""Name"": ""移动"",
    ""PlusName"": ""China Mobile"",
    ""Country"": ""中国"",
    ""Category"": ""Tech"",
    ""Grade"": 2,
    ""Tip"": ""中国三大运营商份额居首""
  },
  {
    ""ID"": 35,
    ""Name"": ""A站"",
    ""PlusName"": ""AcFun"",
    ""Country"": ""中国"",
    ""Category"": ""AV"",
    ""Grade"": 2,
    ""Tip"": ""中国大陆第一家弹幕视频网站，中国二次元文化的开创者、引领者""
  },
  {
    ""ID"": 36,
    ""Name"": ""哔哩哔哩"",
    ""PlusName"": ""Bilibili"",
    ""Country"": ""中国"",
    ""Category"": ""AV"",
    ""Grade"": 2,
    ""Tip"": ""国内最大的年轻人潮流文化娱乐社区""
  },
  {
    ""ID"": 37,
    ""Name"": ""宝马"",
    ""PlusName"": ""BMW"",
    ""Country"": ""德国"",
    ""Category"": ""Car"",
    ""Grade"": 2,
    ""Tip"": ""德系三大豪华品牌之一""
  },
  {
    ""ID"": 38,
    ""Name"": ""本田"",
    ""PlusName"": ""HONDA"",
    ""Country"": ""日本"",
    ""Category"": ""Car"",
    ""Grade"": 2,
    ""Tip"": ""日本汽车品牌，也是世界上最大的摩托车生产厂家""
  },
  {
    ""ID"": 39,
    ""Name"": ""丰田"",
    ""PlusName"": ""TOYATA"",
    ""Country"": ""日本"",
    ""Category"": ""Car"",
    ""Grade"": 2,
    ""Tip"": ""日本最大的汽车公司""
  },
  {
    ""ID"": 40,
    ""Name"": ""阿迪达斯"",
    ""PlusName"": ""adidas"",
    ""Country"": ""德国"",
    ""Category"": ""Fashion"",
    ""Grade"": 2,
    ""Tip"": ""德国著名运动品牌的运动表现系列""
  },
  {
    ""ID"": 41,
    ""Name"": ""安踏"",
    ""PlusName"": ""ANTA"",
    ""Country"": ""中国"",
    ""Category"": ""Fashion"",
    ""Grade"": 2,
    ""Tip"": ""中国领先的体育用品品牌，口号：永不止步""
  },
  {
    ""ID"": 42,
    ""Name"": ""361度"",
    ""PlusName"": ""361°"",
    ""Country"": ""中国"",
    ""Category"": ""Fashion"",
    ""Grade"": 2,
    ""Tip"": ""中国领先的运动品牌，口号：多一度热爱""
  },
  {
    ""ID"": 43,
    ""Name"": ""霸王"",
    ""PlusName"": ""-"",
    ""Country"": ""中国"",
    ""Category"": ""Lifestyle"",
    ""Grade"": 2,
    ""Tip"": ""\""\""\""中药世家\""\""研制\""""
  },
  {
    ""ID"": 44,
    ""Name"": ""蒙牛"",
    ""PlusName"": ""MENGNIU"",
    ""Country"": ""中国"",
    ""Category"": ""Cater"",
    ""Grade"": 2,
    ""Tip"": ""中国奶制品营业额第二""
  },
  {
    ""ID"": 45,
    ""Name"": ""可口可乐"",
    ""PlusName"": ""Coca-Cola"",
    ""Country"": ""美国"",
    ""Category"": ""Cater"",
    ""Grade"": 2,
    ""Tip"": ""全球最大的饮料厂商""
  },
  {
    ""ID"": 46,
    ""Name"": ""LG"",
    ""PlusName"": ""-"",
    ""Country"": ""韩国"",
    ""Category"": ""Tech"",
    ""Grade"": 3,
    ""Tip"": ""韩国电子业第二大集团""
  },
  {
    ""ID"": 47,
    ""Name"": ""安卓"",
    ""PlusName"": ""Android"",
    ""Country"": ""美国"",
    ""Category"": ""Tech"",
    ""Grade"": 3,
    ""Tip"": ""Google公司开发的移动操作系统""
  },
  {
    ""ID"": 48,
    ""Name"": ""戴尔"",
    ""PlusName"": ""DELL"",
    ""Country"": ""美国"",
    ""Category"": ""Tech"",
    ""Grade"": 3,
    ""Tip"": ""口号：The power to do more(激发无限)""
  },
  {
    ""ID"": 49,
    ""Name"": ""德克士"",
    ""PlusName"": ""dicos"",
    ""Country"": ""中国"",
    ""Category"": ""Cater"",
    ""Grade"": 3,
    ""Tip"": ""中国西式快餐特许加盟第一品牌""
  },
  {
    ""ID"": 50,
    ""Name"": ""东芝"",
    ""PlusName"": ""Toshiba"",
    ""Country"": ""日本"",
    ""Category"": ""Tech"",
    ""Grade"": 3,
    ""Tip"": ""日本最大的半导体制造商""
  },
  {
    ""ID"": 51,
    ""Name"": ""飞信"",
    ""PlusName"": ""Fetion"",
    ""Country"": ""中国"",
    ""Category"": ""Tech"",
    ""Grade"": 3,
    ""Tip"": ""中国移动推出的综合通信服务""
  },
  {
    ""ID"": 52,
    ""Name"": ""谷歌"",
    ""PlusName"": ""Google"",
    ""Country"": ""美国"",
    ""Category"": ""Tech"",
    ""Grade"": 3,
    ""Tip"": ""旗下拥有全球最大的搜索引擎""
  },
  {
    ""ID"": 53,
    ""Name"": ""黑莓"",
    ""PlusName"": ""BlackBerry"",
    ""Country"": ""加拿大"",
    ""Category"": ""Tech"",
    ""Grade"": 3,
    ""Tip"": ""其手机产品往往配备有QWERTY全键盘""
  },
  {
    ""ID"": 54,
    ""Name"": ""宏达"",
    ""PlusName"": ""HTC"",
    ""Country"": ""中国"",
    ""Category"": ""Tech"",
    ""Grade"": 3,
    ""Tip"": ""全球最大的智能手机代工和生产厂商""
  },
  {
    ""ID"": 55,
    ""Name"": ""惠普"",
    ""PlusName"": ""HP"",
    ""Country"": ""美国"",
    ""Category"": ""Tech"",
    ""Grade"": 3,
    ""Tip"": ""世界最大的IT公司之一，曾收购康柏电脑""
  },
  {
    ""ID"": 56,
    ""Name"": ""交通银行"",
    ""PlusName"": ""BOCOM"",
    ""Country"": ""中国"",
    ""Category"": ""Lifestyle"",
    ""Grade"": 3,
    ""Tip"": ""中国近代以来延续历史最悠久、最古老的银行""
  },
  {
    ""ID"": 57,
    ""Name"": ""金龙鱼"",
    ""PlusName"": ""-"",
    ""Country"": ""新加坡"",
    ""Category"": ""Lifestyle"",
    ""Grade"": 3,
    ""Tip"": ""世界500强丰益国际旗下著名粮油品牌""
  },
  {
    ""ID"": 58,
    ""Name"": ""联想"",
    ""PlusName"": ""Lenovo"",
    ""Country"": ""中国"",
    ""Category"": ""Tech"",
    ""Grade"": 3,
    ""Tip"": ""其电脑销量位居中国首位，2013年超越惠普成为全球最大的PC生产厂商""
  },
  {
    ""ID"": 59,
    ""Name"": ""漫威"",
    ""PlusName"": ""Marvel"",
    ""Country"": ""美国"",
    ""Category"": ""AV"",
    ""Grade"": 3,
    ""Tip"": ""美国漫画巨头，旗下有蜘蛛侠、美国队长等角色""
  },
  {
    ""ID"": 60,
    ""Name"": ""摩托罗拉"",
    ""PlusName"": ""Motorola"",
    ""Country"": ""美国"",
    ""Category"": ""Tech"",
    ""Grade"": 3,
    ""Tip"": ""全球芯片制造、电子通讯的领导者，其移动业务先后被谷歌和联想收购""
  },
  {
    ""ID"": 61,
    ""Name"": ""尼康"",
    ""PlusName"": ""Nicon"",
    ""Country"": ""日本"",
    ""Category"": ""Tech"",
    ""Grade"": 3,
    ""Tip"": ""日本著名相机品牌，排名仅次于佳能""
  },
  {
    ""ID"": 62,
    ""Name"": ""雀巢"",
    ""PlusName"": ""Nestle"",
    ""Country"": ""瑞士"",
    ""Category"": ""Cater"",
    ""Grade"": 3,
    ""Tip"": ""世界上最大的食品制造商，以生产巧克力棒和速溶咖啡闻名""
  },
  {
    ""ID"": 63,
    ""Name"": ""三星"",
    ""PlusName"": ""Samsung"",
    ""Country"": ""韩国"",
    ""Category"": ""Tech"",
    ""Grade"": 3,
    ""Tip"": ""韩国最大的跨国企业集团""
  },
  {
    ""ID"": 64,
    ""Name"": ""新浪"",
    ""PlusName"": ""Sina"",
    ""Country"": ""中国"",
    ""Category"": ""Tech"",
    ""Grade"": 3,
    ""Tip"": ""四大综合门户网站之首""
  },
  {
    ""ID"": 65,
    ""Name"": ""真功夫"",
    ""PlusName"": ""True Kungfu"",
    ""Country"": ""中国"",
    ""Category"": ""Cater"",
    ""Grade"": 3,
    ""Tip"": ""中国快餐行业前五强中唯一的本土品牌""
  },
  {
    ""ID"": 66,
    ""Name"": ""中国银行"",
    ""PlusName"": ""BOC"",
    ""Country"": ""中国"",
    ""Category"": ""Lifestyle"",
    ""Grade"": 3,
    ""Tip"": ""\""中国五大银行之一，标志像一个\""\""中\""\""字\""""
  },
  {
    ""ID"": 67,
    ""Name"": ""YouTube"",
    ""PlusName"": ""-"",
    ""Country"": ""美国"",
    ""Category"": ""AV"",
    ""Grade"": 3,
    ""Tip"": ""世界上最大的视频网站，现属谷歌""
  },
  {
    ""ID"": 68,
    ""Name"": ""奔驰"",
    ""PlusName"": ""Mercedes-Benz"",
    ""Country"": ""德国"",
    ""Category"": ""Car"",
    ""Grade"": 3,
    ""Tip"": ""三叉星标志，德国高档汽车品牌""
  },
  {
    ""ID"": 69,
    ""Name"": ""三菱"",
    ""PlusName"": ""Mitsubishi"",
    ""Country"": ""日本"",
    ""Category"": ""Car"",
    ""Grade"": 3,
    ""Tip"": ""日本汽车行业中最年轻的汽车制造公司""
  },
  {
    ""ID"": 70,
    ""Name"": ""ZARA"",
    ""PlusName"": ""-"",
    ""Country"": ""西班牙"",
    ""Category"": ""Fashion"",
    ""Grade"": 3,
    ""Tip"": ""西班牙排名第一、全球排名第三的服装商""
  },
  {
    ""ID"": 71,
    ""Name"": ""H\u0026M"",
    ""PlusName"": ""-"",
    ""Country"": ""瑞典"",
    ""Category"": ""Fashion"",
    ""Grade"": 3,
    ""Tip"": ""来自于瑞典的世界知名服装商""
  },
  {
    ""ID"": 72,
    ""Name"": ""彪马"",
    ""PlusName"": ""PUMA"",
    ""Country"": ""德国"",
    ""Category"": ""Fashion"",
    ""Grade"": 3,
    ""Tip"": ""德国著名运动品牌，口号：Forever Faster""
  },
  {
    ""ID"": 73,
    ""Name"": ""卡帕"",
    ""PlusName"": ""kappa"",
    ""Country"": ""意大利"",
    ""Category"": ""Fashion"",
    ""Grade"": 3,
    ""Tip"": ""\""在中国常误译为\""\""背靠背\""\""\""""
  },
  {
    ""ID"": 74,
    ""Name"": ""特步"",
    ""PlusName"": ""Xtep"",
    ""Country"": ""中国"",
    ""Category"": ""Fashion"",
    ""Grade"": 3,
    ""Tip"": ""中国时尚运动品牌，首创娱乐明星代言体育用品的全新模式""
  },
  {
    ""ID"": 75,
    ""Name"": ""鸿星尔克"",
    ""PlusName"": ""ERKE"",
    ""Country"": ""中国"",
    ""Category"": ""Fashion"",
    ""Grade"": 3,
    ""Tip"": ""口号：TO BE No.1""
  },
  {
    ""ID"": 76,
    ""Name"": ""Jeep"",
    ""PlusName"": ""-"",
    ""Country"": ""美国"",
    ""Category"": ""Car"",
    ""Grade"": 3,
    ""Tip"": ""经典广告词：不是所有的吉普都叫XXX""
  },
  {
    ""ID"": 77,
    ""Name"": ""雪佛兰"",
    ""PlusName"": ""Chevrolet"",
    ""Country"": ""美国"",
    ""Category"": ""Car"",
    ""Grade"": 3,
    ""Tip"": ""通用汽车旗下最为国际化和大众化的汽车品牌""
  },
  {
    ""ID"": 78,
    ""Name"": ""汰渍"",
    ""PlusName"": ""Tide"",
    ""Country"": ""美国"",
    ""Category"": ""Lifestyle"",
    ""Grade"": 3,
    ""Tip"": ""\""宝洁旗下著名洗涤品牌，\""\""有xx，没污渍\""\""\""""
  },
  {
    ""ID"": 79,
    ""Name"": ""伊利"",
    ""PlusName"": ""Yili"",
    ""Country"": ""中国"",
    ""Category"": ""Cater"",
    ""Grade"": 3,
    ""Tip"": ""亚洲乳业第一""
  },
  {
    ""ID"": 80,
    ""Name"": ""百事可乐"",
    ""PlusName"": ""Pepsi Cola"",
    ""Country"": ""美国"",
    ""Category"": ""Cater"",
    ""Grade"": 3,
    ""Tip"": ""碳酸饮料，可口可乐的主要竞争对手""
  },
  {
    ""ID"": 81,
    ""Name"": ""美的"",
    ""PlusName"": ""Midea"",
    ""Country"": ""中国"",
    ""Category"": ""Tech"",
    ""Grade"": 3,
    ""Tip"": ""\""\""\""原来生活可以更美的\""\""\""""
  },
  {
    ""ID"": 82,
    ""Name"": ""标致"",
    ""PlusName"": ""PEUGEOT"",
    ""Country"": ""法国"",
    ""Category"": ""Car"",
    ""Grade"": 3,
    ""Tip"": ""与雪铁龙同属欧洲第二大汽车制造集团旗下""
  },
  {
    ""ID"": 83,
    ""Name"": ""Adobe"",
    ""PlusName"": ""-"",
    ""Country"": ""美国"",
    ""Category"": ""Tech"",
    ""Grade"": 4,
    ""Tip"": ""图像元老Photoshop的开发商""
  },
  {
    ""ID"": 84,
    ""Name"": ""Cherry"",
    ""PlusName"": ""-"",
    ""Country"": ""德国"",
    ""Category"": ""Tech"",
    ""Grade"": 4,
    ""Tip"": ""全球数一数二的专业键盘制造厂商，以机械键盘闻名世界""
  },
  {
    ""ID"": 85,
    ""Name"": ""DC"",
    ""PlusName"": ""-"",
    ""Country"": ""美国"",
    ""Category"": ""AV"",
    ""Grade"": 4,
    ""Tip"": ""美国漫画巨头，创造出世界上第一位超级英雄：超人""
  },
  {
    ""ID"": 86,
    ""Name"": ""阿里巴巴"",
    ""PlusName"": ""Alibaba"",
    ""Country"": ""中国"",
    ""Category"": ""Tech"",
    ""Grade"": 4,
    ""Tip"": ""创始人马云，目前已成为全球最大的零售交易平台""
  },
  {
    ""ID"": 87,
    ""Name"": ""宾得"",
    ""PlusName"": ""PENTAX"",
    ""Country"": ""日本"",
    ""Category"": ""Tech"",
    ""Grade"": 4,
    ""Tip"": ""曾是旭光学公司的单反相机品牌""
  },
  {
    ""ID"": 88,
    ""Name"": ""迪士尼"",
    ""PlusName"": ""Disney"",
    ""Country"": ""美国"",
    ""Category"": ""AV"",
    ""Grade"": 4,
    ""Tip"": ""\""创造了\""\""米老鼠\""\""这一举世闻名的动画形象\""""
  },
  {
    ""ID"": 89,
    ""Name"": ""飞利浦"",
    ""PlusName"": ""Philips"",
    ""Country"": ""荷兰"",
    ""Category"": ""Tech"",
    ""Grade"": 4,
    ""Tip"": ""来自荷兰的世界知名电子品牌""
  },
  {
    ""ID"": 90,
    ""Name"": ""哈根达斯"",
    ""PlusName"": ""H?agen-Dazs"",
    ""Country"": ""美国"",
    ""Category"": ""Cater"",
    ""Grade"": 4,
    ""Tip"": ""风靡全球的冰淇淋品牌""
  },
  {
    ""ID"": 91,
    ""Name"": ""华润万家"",
    ""PlusName"": ""Vanguard"",
    ""Country"": ""中国"",
    ""Category"": ""Lifestyle"",
    ""Grade"": 4,
    ""Tip"": ""华润旗下的零售连锁企业品牌""
  },
  {
    ""ID"": 92,
    ""Name"": ""华为"",
    ""PlusName"": ""HuaWei"",
    ""Country"": ""中国"",
    ""Category"": ""Tech"",
    ""Grade"": 4,
    ""Tip"": ""\""旗下有互联网手机品牌\""\""荣耀\""\""\""""
  },
  {
    ""ID"": 93,
    ""Name"": ""雷蛇"",
    ""PlusName"": ""Razer"",
    ""Country"": ""美国"",
    ""Category"": ""Tech"",
    ""Grade"": 4,
    ""Tip"": ""\""全球顶级游戏外设品牌，宗旨是：\""\""始于玩家，赋予玩家\""\"" \""""
  },
  {
    ""ID"": 94,
    ""Name"": ""梦工厂"",
    ""PlusName"": ""DreamWorks"",
    ""Country"": ""美国"",
    ""Category"": ""AV"",
    ""Grade"": 4,
    ""Tip"": ""电影公司，创始人之一为史蒂文·斯皮尔伯格""
  },
  {
    ""ID"": 95,
    ""Name"": ""奇虎"",
    ""PlusName"": ""360"",
    ""Country"": ""中国"",
    ""Category"": ""Tech"",
    ""Grade"": 4,
    ""Tip"": ""创始人周鸿祎，特色产品有：安全卫士和杀毒软件""
  },
  {
    ""ID"": 96,
    ""Name"": ""人人网"",
    ""PlusName"": ""Renren"",
    ""Country"": ""中国"",
    ""Category"": ""Tech"",
    ""Grade"": 4,
    ""Tip"": ""中国类似Facebook的实名制社交网络平台""
  },
  {
    ""ID"": 97,
    ""Name"": ""搜狐"",
    ""PlusName"": ""SOHU"",
    ""Country"": ""中国"",
    ""Category"": ""Tech"",
    ""Grade"": 4,
    ""Tip"": ""中国四大门户网站之一，创始人张朝阳""
  },
  {
    ""ID"": 98,
    ""Name"": ""网易"",
    ""PlusName"": ""NetEase"",
    ""Country"": ""中国"",
    ""Category"": ""Tech"",
    ""Grade"": 4,
    ""Tip"": ""\""中国四大门户网站之一，公司口号：\""\""网聚人的力量\""\""\""""
  },
  {
    ""ID"": 99,
    ""Name"": ""微软"",
    ""PlusName"": ""Microsoft"",
    ""Country"": ""美国"",
    ""Category"": ""Tech"",
    ""Grade"": 4,
    ""Tip"": ""全球最大的电脑软件提供商，著名产品有Windows/Office""
  },
  {
    ""ID"": 100,
    ""Name"": ""沃尔玛"",
    ""PlusName"": ""Walmart"",
    ""Country"": ""美国"",
    ""Category"": ""Lifestyle"",
    ""Grade"": 4,
    ""Tip"": ""世界连锁企业，世界500强企业之首""
  },
  {
    ""ID"": 101,
    ""Name"": ""喜士多"",
    ""PlusName"": ""C-store"",
    ""Country"": ""中国"",
    ""Category"": ""Lifestyle"",
    ""Grade"": 4,
    ""Tip"": ""便利店品牌之一，与大润发同属润泰集团""
  },
  {
    ""ID"": 102,
    ""Name"": ""小肥羊"",
    ""PlusName"": ""Little Sheep"",
    ""Country"": ""中国"",
    ""Category"": ""Cater"",
    ""Grade"": 4,
    ""Tip"": ""中国首家在香港上市的品牌餐饮企业，被誉为中华火锅第一股""
  },
  {
    ""ID"": 103,
    ""Name"": ""携程"",
    ""PlusName"": ""CTRIP"",
    ""Country"": ""中国"",
    ""Category"": ""Tech"",
    ""Grade"": 4,
    ""Tip"": ""在线票务服务公司，标志物为海豚""
  },
  {
    ""ID"": 104,
    ""Name"": ""中兴"",
    ""PlusName"": ""ZTE"",
    ""Country"": ""中国"",
    ""Category"": ""Tech"",
    ""Grade"": 4,
    ""Tip"": ""中国最大的通信设备上市公司""
  },
  {
    ""ID"": 105,
    ""Name"": ""保时捷"",
    ""PlusName"": ""Porsche"",
    ""Country"": ""德国"",
    ""Category"": ""Car"",
    ""Grade"": 4,
    ""Tip"": ""以生产高级跑车闻名于世界车坛，又叫波尔舍""
  },
  {
    ""ID"": 106,
    ""Name"": ""雷克萨斯"",
    ""PlusName"": ""LEXUS"",
    ""Country"": ""日本"",
    ""Category"": ""Car"",
    ""Grade"": 4,
    ""Tip"": ""丰田集团旗下全球著名豪华汽车品牌""
  },
  {
    ""ID"": 107,
    ""Name"": ""马自达"",
    ""PlusName"": ""MAZDA"",
    ""Country"": ""日本"",
    ""Category"": ""Car"",
    ""Grade"": 4,
    ""Tip"": ""日本第四大汽车制造商，世界上唯一研发和生产转子发动机的汽车公司""
  },
  {
    ""ID"": 108,
    ""Name"": ""GAP"",
    ""PlusName"": ""盖璞"",
    ""Country"": ""美国"",
    ""Category"": ""Fashion"",
    ""Grade"": 4,
    ""Tip"": ""美国第一大服装零售品牌""
  },
  {
    ""ID"": 109,
    ""Name"": ""匹克"",
    ""PlusName"": ""PEAK"",
    ""Country"": ""中国"",
    ""Category"": ""Fashion"",
    ""Grade"": 4,
    ""Tip"": ""口号：I CAN PLAY""
  },
  {
    ""ID"": 110,
    ""Name"": ""福特"",
    ""PlusName"": ""Ford"",
    ""Country"": ""美国"",
    ""Category"": ""Car"",
    ""Grade"": 4,
    ""Tip"": ""口号：进无止境""
  },
  {
    ""ID"": 111,
    ""Name"": ""奥利奥"",
    ""PlusName"": ""Oreo"",
    ""Country"": ""美国"",
    ""Category"": ""Cater"",
    ""Grade"": 4,
    ""Tip"": ""全球巧克力味夹心饼干的代名词""
  },
  {
    ""ID"": 112,
    ""Name"": ""美特斯邦威"",
    ""PlusName"": ""Meters Bonwe"",
    ""Country"": ""中国"",
    ""Category"": ""Fashion"",
    ""Grade"": 4,
    ""Tip"": ""中国本土休闲服品牌，创始人：周成建""
  },
  {
    ""ID"": 113,
    ""Name"": ""格力"",
    ""PlusName"": ""GREE"",
    ""Country"": ""中国"",
    ""Category"": ""Tech"",
    ""Grade"": 4,
    ""Tip"": ""\""\""\""掌握核心科技\""\""\""""
  },
  {
    ""ID"": 114,
    ""Name"": ""冠捷"",
    ""PlusName"": ""AOC"",
    ""Country"": ""中国"",
    ""Category"": ""Tech"",
    ""Grade"": 4,
    ""Tip"": ""中国显示器市场销量第一""
  },
  {
    ""ID"": 115,
    ""Name"": ""西门子"",
    ""PlusName"": ""SIEMENS"",
    ""Country"": ""德国"",
    ""Category"": ""Tech"",
    ""Grade"": 4,
    ""Tip"": ""电子电气领头企业，罗永浩砸过其冰箱""
  },
  {
    ""ID"": 116,
    ""Name"": ""雪铁龙"",
    ""PlusName"": ""Citroen"",
    ""Country"": ""法国"",
    ""Category"": ""Car"",
    ""Grade"": 4,
    ""Tip"": ""与标致同属欧洲第二大汽车制造集团旗下""
  },
  {
    ""ID"": 117,
    ""Name"": ""法拉利"",
    ""PlusName"": ""Ferrari"",
    ""Country"": ""意大利"",
    ""Category"": ""Car"",
    ""Grade"": 4,
    ""Tip"": ""世界闻名的赛车和运动跑车的生产厂家，现属菲亚特集团""
  },
  {
    ""ID"": 118,
    ""Name"": ""IBM"",
    ""PlusName"": ""-"",
    ""Country"": ""美国"",
    ""Category"": ""Tech"",
    ""Grade"": 5,
    ""Tip"": ""全球最大的信息技术和业务解决方案公司""
  },
  {
    ""ID"": 119,
    ""Name"": ""艾德熊"",
    ""PlusName"": ""A\u0026W"",
    ""Country"": ""美国"",
    ""Category"": ""Cater"",
    ""Grade"": 5,
    ""Tip"": ""\""创造出了\""\""乐啤露\""\""极富天然成分的饮料\""""
  },
  {
    ""ID"": 120,
    ""Name"": ""奥林巴斯"",
    ""PlusName"": ""Olympus"",
    ""Country"": ""日本"",
    ""Category"": ""Tech"",
    ""Grade"": 5,
    ""Tip"": ""在日本第一次成功地将显微镜商品化""
  },
  {
    ""ID"": 121,
    ""Name"": ""百胜"",
    ""PlusName"": ""Tricon"",
    ""Country"": ""美国"",
    ""Category"": ""Cater"",
    ""Grade"": 5,
    ""Tip"": ""全球最大的餐饮集团""
  },
  {
    ""ID"": 122,
    ""Name"": ""达美乐"",
    ""PlusName"": ""Domino"",
    ""Country"": ""美国"",
    ""Category"": ""Cater"",
    ""Grade"": 5,
    ""Tip"": ""世界三大披萨品牌之一""
  },
  {
    ""ID"": 123,
    ""Name"": ""哥伦比亚"",
    ""PlusName"": ""Columbia"",
    ""Country"": ""美国"",
    ""Category"": ""AV"",
    ""Grade"": 5,
    ""Tip"": ""好莱坞八大电影公司之一，目前属索尼旗下""
  },
  {
    ""ID"": 124,
    ""Name"": ""海思"",
    ""PlusName"": ""Hisilicon"",
    ""Country"": ""中国"",
    ""Category"": ""Tech"",
    ""Grade"": 5,
    ""Tip"": ""前身是华为集成电路设计中心""
  },
  {
    ""ID"": 125,
    ""Name"": ""环球"",
    ""PlusName"": ""Universal Picture"",
    ""Country"": ""美国"",
    ""Category"": ""AV"",
    ""Grade"": 5,
    ""Tip"": ""\""好莱坞八大电影公司之一，曾出品过\""\""侏罗纪公园\""\""\""""
  },
  {
    ""ID"": 126,
    ""Name"": ""技嘉"",
    ""PlusName"": ""GIGABYTE"",
    ""Country"": ""中国"",
    ""Category"": ""Tech"",
    ""Grade"": 5,
    ""Tip"": ""台湾第二大专业主板制造商""
  },
  {
    ""ID"": 127,
    ""Name"": ""家乐福"",
    ""PlusName"": ""Carrefour"",
    ""Country"": ""法国"",
    ""Category"": ""Lifestyle"",
    ""Grade"": 5,
    ""Tip"": ""欧洲第一大零售商""
  },
  {
    ""ID"": 128,
    ""Name"": ""卡西欧"",
    ""PlusName"": ""CASIO"",
    ""Country"": ""日本"",
    ""Category"": ""Tech"",
    ""Grade"": 5,
    ""Tip"": ""生产电子仪器、电子计算器为主，在中国以其计算器、手表闻名""
  },
  {
    ""ID"": 129,
    ""Name"": ""莱卡"",
    ""PlusName"": ""leica"",
    ""Country"": ""德国"",
    ""Category"": ""Tech"",
    ""Grade"": 5,
    ""Tip"": ""产于德国的精良世界级相机品牌""
  },
  {
    ""ID"": 130,
    ""Name"": ""乐购"",
    ""PlusName"": ""TESCO"",
    ""Country"": ""英国"",
    ""Category"": ""Lifestyle"",
    ""Grade"": 5,
    ""Tip"": ""英国最大的零售公司，世界三大零售商之一""
  },
  {
    ""ID"": 131,
    ""Name"": ""去哪儿"",
    ""PlusName"": ""Qunar"",
    ""Country"": ""中国"",
    ""Category"": ""Tech"",
    ""Grade"": 5,
    ""Tip"": ""中文在线旅行网站，现与携程网合并""
  },
  {
    ""ID"": 132,
    ""Name"": ""全家"",
    ""PlusName"": ""FamilyMart"",
    ""Country"": ""日本"",
    ""Category"": ""Lifestyle"",
    ""Grade"": 5,
    ""Tip"": ""第一家由亚洲发起进入美国市场的便利店企业""
  },
  {
    ""ID"": 133,
    ""Name"": ""赛百味"",
    ""PlusName"": ""Subway"",
    ""Country"": ""美国"",
    ""Category"": ""Cater"",
    ""Grade"": 5,
    ""Tip"": ""世界上扩张最快及最大单一品牌连锁店，主要贩售三明治和沙拉""
  },
  {
    ""ID"": 134,
    ""Name"": ""索尼"",
    ""PlusName"": ""Sony"",
    ""Country"": ""日本"",
    ""Category"": ""Tech"",
    ""Grade"": 5,
    ""Tip"": ""世界最早便携式数码产品的开创者""
  },
  {
    ""ID"": 135,
    ""Name"": ""唯品会"",
    ""PlusName"": ""Vipshop"",
    ""Country"": ""中国"",
    ""Category"": ""Tech"",
    ""Grade"": 5,
    ""Tip"": ""\""定位于\""\""一家专门做特卖的网站\""\""\""""
  },
  {
    ""ID"": 136,
    ""Name"": ""味全"",
    ""PlusName"": ""wei-chuan"",
    ""Country"": ""中国"",
    ""Category"": ""Lifestyle"",
    ""Grade"": 5,
    ""Tip"": ""台湾知名综合食品企业，现属顶新集团""
  },
  {
    ""ID"": 137,
    ""Name"": ""许留山"",
    ""PlusName"": ""HuiLauShan"",
    ""Country"": ""中国"",
    ""Category"": ""Cater"",
    ""Grade"": 5,
    ""Tip"": ""香港著名连锁式甜品店，以芒果为主要材料""
  },
  {
    ""ID"": 138,
    ""Name"": ""英特尔"",
    ""PlusName"": ""Intel"",
    ""Country"": ""美国"",
    ""Category"": ""Tech"",
    ""Grade"": 5,
    ""Tip"": ""全球最大的个人计算机零件和CPU制造商""
  },
  {
    ""ID"": 139,
    ""Name"": ""英伟达"",
    ""PlusName"": ""NVIDA"",
    ""Country"": ""美国"",
    ""Category"": ""Tech"",
    ""Grade"": 5,
    ""Tip"": ""全球著名IC半导体公司，其显卡俗称N卡""
  },
  {
    ""ID"": 140,
    ""Name"": ""永辉超市"",
    ""PlusName"": ""YONGHUI"",
    ""Country"": ""中国"",
    ""Category"": ""Lifestyle"",
    ""Grade"": 5,
    ""Tip"": ""中国十强连锁超市，创始人张轩松""
  },
  {
    ""ID"": 141,
    ""Name"": ""Netflix"",
    ""PlusName"": ""-"",
    ""Country"": ""美国"",
    ""Category"": ""AV"",
    ""Grade"": 5,
    ""Tip"": ""世界最大的在线影片租赁服务商""
  },
  {
    ""ID"": 142,
    ""Name"": ""MINI"",
    ""PlusName"": ""-"",
    ""Country"": ""德国"",
    ""Category"": ""Car"",
    ""Grade"": 5,
    ""Tip"": ""英国BMC汽车公司推出，后属宝马公司""
  },
  {
    ""ID"": 143,
    ""Name"": ""日产"",
    ""PlusName"": ""NISSAN"",
    ""Country"": ""日本"",
    ""Category"": ""Car"",
    ""Grade"": 5,
    ""Tip"": ""日本第二大汽车制造商""
  },
  {
    ""ID"": 144,
    ""Name"": ""现代"",
    ""PlusName"": ""HYUNDAI"",
    ""Country"": ""韩国"",
    ""Category"": ""Car"",
    ""Grade"": 5,
    ""Tip"": ""韩国汽车品牌，主要生产suv及普通家用轿车""
  },
  {
    ""ID"": 145,
    ""Name"": ""乔丹"",
    ""PlusName"": ""QIAODAN"",
    ""Country"": ""中国"",
    ""Category"": ""Fashion"",
    ""Grade"": 5,
    ""Tip"": ""口号：跨越.新生""
  },
  {
    ""ID"": 146,
    ""Name"": ""锐步"",
    ""PlusName"": ""Reebok"",
    ""Country"": ""美国"",
    ""Category"": ""Fashion"",
    ""Grade"": 5,
    ""Tip"": ""美国运动品牌Reebok，后被阿迪达斯收购""
  },
  {
    ""ID"": 147,
    ""Name"": ""别克"",
    ""PlusName"": ""Buick"",
    ""Country"": ""美国"",
    ""Category"": ""Car"",
    ""Grade"": 5,
    ""Tip"": ""\""通用旗下汽车品牌，商标为著名的\""\""三盾\""\""标志\""""
  },
  {
    ""ID"": 148,
    ""Name"": ""凯迪拉克"",
    ""PlusName"": ""Cadillac"",
    ""Country"": ""美国"",
    ""Category"": ""Car"",
    ""Grade"": 5,
    ""Tip"": ""\""通用集团旗下一款豪华汽车品牌，标志为\""\""冠\""\""+\""\""盾\""\""\""""
  },
  {
    ""ID"": 149,
    ""Name"": ""特斯拉"",
    ""PlusName"": ""Tesla"",
    ""Country"": ""美国"",
    ""Category"": ""Car"",
    ""Grade"": 5,
    ""Tip"": ""最著名的高性能纯电动汽车品牌""
  },
  {
    ""ID"": 150,
    ""Name"": ""Facebook"",
    ""PlusName"": ""-"",
    ""Country"": ""美国"",
    ""Category"": ""Tech"",
    ""Grade"": 5,
    ""Tip"": ""世界排名第一的照片分享站点""
  },
  {
    ""ID"": 151,
    ""Name"": ""Twitter"",
    ""PlusName"": ""-"",
    ""Country"": ""美国"",
    ""Category"": ""Tech"",
    ""Grade"": 5,
    ""Tip"": ""美国社交及微博客服务的网站，每条消息不超过140个字""
  },
  {
    ""ID"": 152,
    ""Name"": ""爱国者"",
    ""PlusName"": ""aigo"",
    ""Country"": ""中国"",
    ""Category"": ""Tech"",
    ""Grade"": 5,
    ""Tip"": ""华旗资讯旗下数码品牌""
  },
  {
    ""ID"": 153,
    ""Name"": ""宝洁"",
    ""PlusName"": ""P\u0026G"",
    ""Country"": ""美国"",
    ""Category"": ""Lifestyle"",
    ""Grade"": 5,
    ""Tip"": ""全球最大的日用消费品公司""
  },
  {
    ""ID"": 154,
    ""Name"": ""如家"",
    ""PlusName"": ""Home Inn"",
    ""Country"": ""中国"",
    ""Category"": ""Lifestyle"",
    ""Grade"": 5,
    ""Tip"": ""品牌价值居中国酒店行业之首""
  },
  {
    ""ID"": 155,
    ""Name"": ""优衣库"",
    ""PlusName"": ""UNIQLO"",
    ""Country"": ""日本"",
    ""Category"": ""Fashion"",
    ""Grade"": 5,
    ""Tip"": ""日本国际知名服装品牌，曾出过xxx试衣间热点新闻""
  },
  {
    ""ID"": 156,
    ""Name"": ""明基"",
    ""PlusName"": ""BenQ"",
    ""Country"": ""中国"",
    ""Category"": ""Tech"",
    ""Grade"": 5,
    ""Tip"": ""创始人同宏碁：施振荣""
  },
  {
    ""ID"": 157,
    ""Name"": ""DS"",
    ""PlusName"": ""-"",
    ""Country"": ""法国"",
    ""Category"": ""Car"",
    ""Grade"": 5,
    ""Tip"": ""法国总统座驾，法国汽车工业顶级设计豪华品牌""
  },
  {
    ""ID"": 158,
    ""Name"": ""雷诺"",
    ""PlusName"": ""Renault"",
    ""Country"": ""法国"",
    ""Category"": ""Car"",
    ""Grade"": 5,
    ""Tip"": ""口号：“Drive the Change”""
  },
  {
    ""ID"": 159,
    ""Name"": ""兰博基尼"",
    ""PlusName"": ""Lamborghini"",
    ""Country"": ""意大利"",
    ""Category"": ""Car"",
    ""Grade"": 5,
    ""Tip"": ""全球顶级跑车制造商，其标志是一头充满力量、正向对方攻击的斗牛""
  },
  {
    ""ID"": 160,
    ""Name"": ""棒约翰"",
    ""PlusName"": ""Papa Johns"",
    ""Country"": ""美国"",
    ""Category"": ""Cater"",
    ""Grade"": 6,
    ""Tip"": ""世界三大披萨品牌之一：Better Ingredients，Better pizza！""
  },
  {
    ""ID"": 161,
    ""Name"": ""冰雪皇后"",
    ""PlusName"": ""Dairy Queen"",
    ""Country"": ""美国"",
    ""Category"": ""Cater"",
    ""Grade"": 6,
    ""Tip"": ""世界最大软冰淇淋销售商""
  },
  {
    ""ID"": 162,
    ""Name"": ""德州仪器"",
    ""PlusName"": ""TI"",
    ""Country"": ""美国"",
    ""Category"": ""Tech"",
    ""Grade"": 6,
    ""Tip"": ""世界上最大的模拟电路技术部件制造商""
  },
  {
    ""ID"": 163,
    ""Name"": ""二十世纪福克斯"",
    ""PlusName"": ""20th Century Fox"",
    ""Country"": ""美国"",
    ""Category"": ""AV"",
    ""Grade"": 6,
    ""Tip"": ""\""好莱坞八大电影公司之一，发行过\""\""星球大战\""\""\""""
  },
  {
    ""ID"": 164,
    ""Name"": ""飞思卡尔"",
    ""PlusName"": ""Freescale"",
    ""Country"": ""美国"",
    ""Category"": ""Tech"",
    ""Grade"": 6,
    ""Tip"": ""全球领先的半导体公司，赞助举办有以其品牌命名的全国大学生智能车竞赛""
  },
  {
    ""ID"": 165,
    ""Name"": ""高通"",
    ""PlusName"": ""Qualcomm"",
    ""Country"": ""美国"",
    ""Category"": ""Tech"",
    ""Grade"": 6,
    ""Tip"": ""无线电通信技术研发公司，目前使用最多的智能手机处理器厂商""
  },
  {
    ""ID"": 166,
    ""Name"": ""汉堡王"",
    ""PlusName"": ""Burger King"",
    ""Country"": ""美国"",
    ""Category"": ""Cater"",
    ""Grade"": 6,
    ""Tip"": ""全球第二大快餐连锁企业""
  },
  {
    ""ID"": 167,
    ""Name"": ""好又多"",
    ""PlusName"": ""TRUST-MART"",
    ""Country"": ""中国"",
    ""Category"": ""Lifestyle"",
    ""Grade"": 6,
    ""Tip"": ""中国大陆连锁分店数量最多的外资商业企业""
  },
  {
    ""ID"": 168,
    ""Name"": ""华纳兄弟"",
    ""PlusName"": ""Warner Bros"",
    ""Country"": ""美国"",
    ""Category"": ""AV"",
    ""Grade"": 6,
    ""Tip"": ""好莱坞八大电影公司之一，创造了007经典影视形象""
  },
  {
    ""ID"": 169,
    ""Name"": ""金士顿"",
    ""PlusName"": ""kingston"",
    ""Country"": ""美国"",
    ""Category"": ""Tech"",
    ""Grade"": 6,
    ""Tip"": ""全球最大的独立内存产品制造商""
  },
  {
    ""ID"": 170,
    ""Name"": ""劳斯莱斯"",
    ""PlusName"": ""Rolls-Royce"",
    ""Country"": ""英国"",
    ""Category"": ""Car"",
    ""Grade"": 6,
    ""Tip"": ""世界顶级超豪华轿车厂商""
  },
  {
    ""ID"": 171,
    ""Name"": ""联发科"",
    ""PlusName"": ""MediaTek"",
    ""Country"": ""中国"",
    ""Category"": ""Tech"",
    ""Grade"": 6,
    ""Tip"": ""全球著名IC设计厂商，简称MTK""
  },
  {
    ""ID"": 172,
    ""Name"": ""麦德龙"",
    ""PlusName"": ""METRO"",
    ""Country"": ""德国"",
    ""Category"": ""Lifestyle"",
    ""Grade"": 6,
    ""Tip"": ""德国最大、欧洲第二的零售批发超市集团""
  },
  {
    ""ID"": 173,
    ""Name"": ""派拉蒙"",
    ""PlusName"": ""Paramount"",
    ""Country"": ""美国"",
    ""Category"": ""AV"",
    ""Grade"": 6,
    ""Tip"": ""\""好莱坞八大电影公司之一，代表作品有：\""\""教父\""\""\""""
  },
  {
    ""ID"": 174,
    ""Name"": ""松下"",
    ""PlusName"": ""Panasonic"",
    ""Country"": ""日本"",
    ""Category"": ""Tech"",
    ""Grade"": 6,
    ""Tip"": ""\""世界500强，口号：\""\""A Better Life A Better World\""\""\""""
  },
  {
    ""ID"": 175,
    ""Name"": ""外星人"",
    ""PlusName"": ""Alienware"",
    ""Country"": ""美国"",
    ""Category"": ""Tech"",
    ""Grade"": 6,
    ""Tip"": ""戴尔旗下高端游戏笔记本品牌""
  },
  {
    ""ID"": 176,
    ""Name"": ""维基百科"",
    ""PlusName"": ""Wikipedia"",
    ""Country"": ""美国"",
    ""Category"": ""Tech"",
    ""Grade"": 6,
    ""Tip"": ""基于维基技术的全球性多语言百科全书""
  },
  {
    ""ID"": 177,
    ""Name"": ""味千拉面"",
    ""PlusName"": ""AJISEN PAMEN"",
    ""Country"": ""日本"",
    ""Category"": ""Cater"",
    ""Grade"": 6,
    ""Tip"": ""特色是拉面及日式美食""
  },
  {
    ""ID"": 178,
    ""Name"": ""兄弟"",
    ""PlusName"": ""Brother"",
    ""Country"": ""日本"",
    ""Category"": ""Tech"",
    ""Grade"": 6,
    ""Tip"": ""最初生产缝纫机，之后以打印机闻名""
  },
  {
    ""ID"": 179,
    ""Name"": ""亚马逊"",
    ""PlusName"": ""Amazon"",
    ""Country"": ""美国"",
    ""Category"": ""Tech"",
    ""Grade"": 6,
    ""Tip"": ""美国最大的一家网络电子商务公司""
  },
  {
    ""ID"": 180,
    ""Name"": ""Hulu"",
    ""PlusName"": ""-"",
    ""Country"": ""美国"",
    ""Category"": ""AV"",
    ""Grade"": 6,
    ""Tip"": ""由美国NBC和FOX共同成立的一家视频分享网站""
  },
  {
    ""ID"": 181,
    ""Name"": ""新百伦"",
    ""PlusName"": ""New Balance"",
    ""Country"": ""美国"",
    ""Category"": ""Fashion"",
    ""Grade"": 6,
    ""Tip"": ""\""美国运动品牌，被誉为\""\""慢跑鞋之王\""\""\""""
  },
  {
    ""ID"": 182,
    ""Name"": ""道奇"",
    ""PlusName"": ""Dodge"",
    ""Country"": ""美国"",
    ""Category"": ""Car"",
    ""Grade"": 6,
    ""Tip"": ""名称采用创始人两兄弟的姓氏，图形商标是五边形中有一羊头的形象""
  },
  {
    ""ID"": 183,
    ""Name"": ""领英"",
    ""PlusName"": ""LinkedIn"",
    ""Country"": ""美国"",
    ""Category"": ""Tech"",
    ""Grade"": 6,
    ""Tip"": ""全球最大的职业社交网站""
  },
  {
    ""ID"": 184,
    ""Name"": ""闪迪"",
    ""PlusName"": ""SanDisk"",
    ""Country"": ""美国"",
    ""Category"": ""Tech"",
    ""Grade"": 6,
    ""Tip"": ""全球最大的闪速数据存储卡产品供应商""
  },
  {
    ""ID"": 185,
    ""Name"": ""安利"",
    ""PlusName"": ""Amway"",
    ""Country"": ""美国"",
    ""Category"": ""Lifestyle"",
    ""Grade"": 6,
    ""Tip"": ""高质量消费品品牌，衍生出同名的网络词汇，意为推荐""
  },
  {
    ""ID"": 186,
    ""Name"": ""卡夫"",
    ""PlusName"": ""Kraft"",
    ""Country"": ""美国"",
    ""Category"": ""Cater"",
    ""Grade"": 6,
    ""Tip"": ""全球第二大食品公司""
  },
  {
    ""ID"": 187,
    ""Name"": ""达能"",
    ""PlusName"": ""Danone"",
    ""Country"": ""法国"",
    ""Category"": ""Cater"",
    ""Grade"": 6,
    ""Tip"": ""欧洲第三大食品集团""
  },
  {
    ""ID"": 188,
    ""Name"": ""普拉达"",
    ""PlusName"": ""PRADA"",
    ""Country"": ""意大利"",
    ""Category"": ""Fashion"",
    ""Grade"": 6,
    ""Tip"": ""\""\""\""穿XXX的女王\""\""，于米兰诞生的奢侈品牌\""""
  },
  {
    ""ID"": 189,
    ""Name"": ""GoPro"",
    ""PlusName"": ""-"",
    ""Country"": ""美国"",
    ""Category"": ""Tech"",
    ""Grade"": 6,
    ""Tip"": ""\""\""\""极限运动专用相机\""\""的代名词\""""
  },
  {
    ""ID"": 190,
    ""Name"": ""爱普生"",
    ""PlusName"": ""Epson"",
    ""Country"": ""日本"",
    ""Category"": ""Tech"",
    ""Grade"": 6,
    ""Tip"": ""口号：Exceed Your Vision""
  },
  {
    ""ID"": 191,
    ""Name"": ""阿玛尼"",
    ""PlusName"": ""Armani"",
    ""Country"": ""意大利"",
    ""Category"": ""Fashion"",
    ""Grade"": 6,
    ""Tip"": ""美国销量最大的欧洲设计师品牌""
  },
  {
    ""ID"": 192,
    ""Name"": ""forever 21"",
    ""PlusName"": ""-"",
    ""Country"": ""美国"",
    ""Category"": ""Fashion"",
    ""Grade"": 6,
    ""Tip"": ""最受美国年轻人欢迎的大众时尚品牌""
  },
  {
    ""ID"": 193,
    ""Name"": ""海康威视"",
    ""PlusName"": ""HIKVISION"",
    ""Country"": ""中国"",
    ""Category"": ""Tech"",
    ""Grade"": 6,
    ""Tip"": ""中国/全球安防第一品牌""
  },
  {
    ""ID"": 194,
    ""Name"": ""大华"",
    ""PlusName"": ""dahua"",
    ""Country"": ""中国"",
    ""Category"": ""Tech"",
    ""Grade"": 6,
    ""Tip"": ""中国安防第二品牌""
  },
  {
    ""ID"": 195,
    ""Name"": ""茅台"",
    ""PlusName"": ""moutai"",
    ""Country"": ""中国"",
    ""Category"": ""Lifestyle"",
    ""Grade"": 6,
    ""Tip"": ""四大名酒之一，产于贵州，世界三大蒸馏名酒之一""
  },
  {
    ""ID"": 196,
    ""Name"": ""汾酒"",
    ""PlusName"": ""-"",
    ""Country"": ""中国"",
    ""Category"": ""Lifestyle"",
    ""Grade"": 6,
    ""Tip"": ""四大名酒之一，产于山西""
  },
  {
    ""ID"": 197,
    ""Name"": ""劳力士"",
    ""PlusName"": ""Rolex"",
    ""Country"": ""瑞士"",
    ""Category"": ""Fashion"",
    ""Grade"": 6,
    ""Tip"": ""\""世界十大名表之一，在中国一枝独秀，曾译\""\""罗莱克斯\""\""\""""
  },
  {
    ""ID"": 198,
    ""Name"": ""大润发"",
    ""PlusName"": ""RT-MART"",
    ""Country"": ""中国"",
    ""Category"": ""Lifestyle"",
    ""Grade"": 7,
    ""Tip"": ""RT-MART，台湾大型连锁量贩店""
  },
  {
    ""ID"": 199,
    ""Name"": ""高通骁龙"",
    ""PlusName"": ""Snapdragon"",
    ""Country"": ""美国"",
    ""Category"": ""Tech"",
    ""Grade"": 7,
    ""Tip"": ""Qualcomm旗下移动处理器和LTE调制解调器的品牌名""
  },
  {
    ""ID"": 200,
    ""Name"": ""海滋客"",
    ""PlusName"": ""Long John Silver\u0027s"",
    ""Country"": ""美国"",
    ""Category"": ""Cater"",
    ""Grade"": 7,
    ""Tip"": ""国际连锁速食餐厅，以海鲜、炸鱼块为其主要特色""
  },
  {
    ""ID"": 201,
    ""Name"": ""柯尼卡美能达"",
    ""PlusName"": ""Konica Minolta"",
    ""Country"": ""日本"",
    ""Category"": ""Tech"",
    ""Grade"": 7,
    ""Tip"": ""\""在中国以大型打印机闻名，企业口号：\""\""The essentials of imaging\""\""\""""
  },
  {
    ""ID"": 202,
    ""Name"": ""蓝天"",
    ""PlusName"": ""Blue sky"",
    ""Country"": ""美国"",
    ""Category"": ""AV"",
    ""Grade"": 7,
    ""Tip"": ""\""好莱坞著名动画工作室，出品有\""\""冰河世纪\""\""\""""
  },
  {
    ""ID"": 203,
    ""Name"": ""联美"",
    ""PlusName"": ""United Artists"",
    ""Country"": ""美国"",
    ""Category"": ""AV"",
    ""Grade"": 7,
    ""Tip"": ""好莱坞八大电影公司之一，现东家为汤姆·克鲁斯""
  },
  {
    ""ID"": 204,
    ""Name"": ""米高梅"",
    ""PlusName"": ""Metro-Goldwyn-Mayer"",
    ""Country"": ""美国"",
    ""Category"": ""AV"",
    ""Grade"": 7,
    ""Tip"": ""好莱坞八大电影公司之一，发起并推出了奥斯卡奖""
  },
  {
    ""ID"": 205,
    ""Name"": ""欧尚"",
    ""PlusName"": ""Auchan"",
    ""Country"": ""法国"",
    ""Category"": ""Lifestyle"",
    ""Grade"": 7,
    ""Tip"": ""法国第二大以经营零售业为主的商业集团，全球十大零售商之一""
  },
  {
    ""ID"": 206,
    ""Name"": ""皮克斯"",
    ""PlusName"": ""Pixar"",
    ""Country"": ""美国"",
    ""Category"": ""AV"",
    ""Grade"": 7,
    ""Tip"": ""迪士尼旗下顶级动画工作室，曾是卢卡斯电影公司的电脑动画部""
  },
  {
    ""ID"": 207,
    ""Name"": ""日立"",
    ""PlusName"": ""HITACHI"",
    ""Country"": ""日本"",
    ""Category"": ""Tech"",
    ""Grade"": 7,
    ""Tip"": ""日本的一家全球最大的综合跨国集团""
  },
  {
    ""ID"": 208,
    ""Name"": ""软银"",
    ""PlusName"": ""SoftBank"",
    ""Country"": ""日本"",
    ""Category"": ""Tech"",
    ""Grade"": 7,
    ""Tip"": ""由孙正义成立的综合性的风险投资公司""
  },
  {
    ""ID"": 209,
    ""Name"": ""施乐"",
    ""PlusName"": ""Xerox"",
    ""Country"": ""美国"",
    ""Category"": ""Tech"",
    ""Grade"": 7,
    ""Tip"": ""全球最大数字与信息技术产品生产商，复印技术的发明公司""
  },
  {
    ""ID"": 210,
    ""Name"": ""塔可钟"",
    ""PlusName"": ""tacobell"",
    ""Country"": ""美国"",
    ""Category"": ""Cater"",
    ""Grade"": 7,
    ""Tip"": ""世界上规模最大的提供墨西哥式食品的连锁餐饮品牌""
  },
  {
    ""ID"": 211,
    ""Name"": ""唐恩都乐"",
    ""PlusName"": ""Dunkin Donuts"",
    ""Country"": ""美国"",
    ""Category"": ""Cater"",
    ""Grade"": 7,
    ""Tip"": ""\""美国十大快餐连锁品牌之一，别名\""\""当肯甜甜圈\""\""\""""
  },
  {
    ""ID"": 212,
    ""Name"": ""意法半导体"",
    ""PlusName"": ""ST"",
    ""Country"": ""意大利/法国"",
    ""Category"": ""Tech"",
    ""Grade"": 7,
    ""Tip"": ""全球第五大半导体厂商""
  },
  {
    ""ID"": 213,
    ""Name"": ""恩智浦"",
    ""PlusName"": ""NXP"",
    ""Country"": ""荷兰"",
    ""Category"": ""Tech"",
    ""Grade"": 7,
    ""Tip"": ""由飞利浦公司创立的半导体公司，后与飞思卡尔合并""
  },
  {
    ""ID"": 214,
    ""Name"": ""林肯"",
    ""PlusName"": ""LINCOLN"",
    ""Country"": ""美国"",
    ""Category"": ""Car"",
    ""Grade"": 7,
    ""Tip"": ""福特旗下豪华汽车品牌，以一位美国总统名字命名""
  },
  {
    ""ID"": 215,
    ""Name"": ""希捷"",
    ""PlusName"": ""Seagate"",
    ""Country"": ""美国"",
    ""Category"": ""Tech"",
    ""Grade"": 7,
    ""Tip"": ""全球最大的硬盘、磁盘和读写磁头制造商""
  },
  {
    ""ID"": 216,
    ""Name"": ""西部数据"",
    ""PlusName"": ""Western Digital"",
    ""Country"": ""美国"",
    ""Category"": ""Tech"",
    ""Grade"": 7,
    ""Tip"": ""全球第二大硬盘生产商""
  },
  {
    ""ID"": 217,
    ""Name"": ""海盗船"",
    ""PlusName"": ""Corsair"",
    ""Country"": ""美国"",
    ""Category"": ""Tech"",
    ""Grade"": 7,
    ""Tip"": ""著名电脑硬件制造商，全球最受尊敬的超频内存制造商""
  },
  {
    ""ID"": 218,
    ""Name"": ""大疆"",
    ""PlusName"": ""-"",
    ""Country"": ""中国"",
    ""Category"": ""Tech"",
    ""Grade"": 7,
    ""Tip"": ""一夜成名的无人机品牌，创始人：汪滔""
  },
  {
    ""ID"": 219,
    ""Name"": ""宜家"",
    ""PlusName"": ""IKEA"",
    ""Country"": ""瑞典"",
    ""Category"": ""Lifestyle"",
    ""Grade"": 7,
    ""Tip"": ""全球最大的家具家居用品商家""
  },
  {
    ""ID"": 220,
    ""Name"": ""爱马仕"",
    ""PlusName"": ""Hermes"",
    ""Country"": ""法国"",
    ""Category"": ""Fashion"",
    ""Grade"": 7,
    ""Tip"": ""法国著名奢侈品品牌，以制造高级马具起家""
  },
  {
    ""ID"": 221,
    ""Name"": ""范思哲"",
    ""PlusName"": ""Versace"",
    ""Country"": ""意大利"",
    ""Category"": ""Fashion"",
    ""Grade"": 7,
    ""Tip"": ""标志是神话中的蛇妖美杜莎，代表着致命的吸引力""
  },
  {
    ""ID"": 222,
    ""Name"": ""泸州老窖"",
    ""PlusName"": ""-"",
    ""Country"": ""中国"",
    ""Category"": ""Lifestyle"",
    ""Grade"": 7,
    ""Tip"": ""\""四大名酒之一，产于四川，\""\""浓香鼻祖 酒中泰斗\""\""\""""
  },
  {
    ""ID"": 223,
    ""Name"": ""西凤酒"",
    ""PlusName"": ""-"",
    ""Country"": ""中国"",
    ""Category"": ""Lifestyle"",
    ""Grade"": 7,
    ""Tip"": ""四大名酒之一，产于陕西""
  },
  {
    ""ID"": 224,
    ""Name"": ""芬迪"",
    ""PlusName"": ""FENDI"",
    ""Country"": ""意大利"",
    ""Category"": ""Fashion"",
    ""Grade"": 7,
    ""Tip"": ""意大利奢侈品品牌，以一家位于罗马的皮革毛皮商店起家""
  },
  {
    ""ID"": 225,
    ""Name"": ""卡地亚"",
    ""PlusName"": ""Cartier"",
    ""Country"": ""法国"",
    ""Category"": ""Fashion"",
    ""Grade"": 7,
    ""Tip"": ""世界上首只戴在手腕的腕表""
  },
  {
    ""ID"": 226,
    ""Name"": ""阿斯顿马丁"",
    ""PlusName"": ""AstonMartin"",
    ""Country"": ""英国"",
    ""Category"": ""Car"",
    ""Grade"": 7,
    ""Tip"": ""其标志是一只展翅飞翔的大鹏""
  },
  {
    ""ID"": 227,
    ""Name"": ""宾利"",
    ""PlusName"": ""Bentley"",
    ""Country"": ""英国"",
    ""Category"": ""Car"",
    ""Grade"": 7,
    ""Tip"": ""著名豪车制造商，98被大众集团收购""
  },
  {
    ""ID"": 228,
    ""Name"": ""布加迪"",
    ""PlusName"": ""Bugatti"",
    ""Country"": ""法国"",
    ""Category"": ""Car"",
    ""Grade"": 7,
    ""Tip"": ""法国跑车品牌，98被大众集团收购""
  }
]
";
            return json;
        }
    }
}
