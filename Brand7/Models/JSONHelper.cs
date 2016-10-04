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
                ""Name"": ""EMS"",
                ""KeyName"": ""EMS"",
                ""PlusName"": ""邮政速递"",
                ""Country"": ""中国"",
                ""Category"": ""Walking"",
                ""Grade"": 1,
                ""Tip"": ""由中国邮政提供的一种快递服务""
              },
              {
                ""ID"": 2,
                ""Name"": ""QQ"",
                ""KeyName"": ""QQ"",
                ""PlusName"": ""-"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 1,
                ""Tip"": ""腾讯出品，中国用户数量最多的社交软件""
              },
              {
                ""ID"": 3,
                ""Name"": ""奥迪"",
                ""KeyName"": ""奥迪"",
                ""PlusName"": ""Audi"",
                ""Country"": ""德国"",
                ""Category"": ""Car"",
                ""Grade"": 1,
                ""Tip"": ""大众旗下的豪华汽车品牌""
              },
              {
                ""ID"": 4,
                ""Name"": ""百度"",
                ""KeyName"": ""百度"",
                ""PlusName"": ""Baidu"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 1,
                ""Tip"": ""全球最大的中文搜索引擎、最大的中文网站""
              },
              {
                ""ID"": 5,
                ""Name"": ""宝马"",
                ""KeyName"": ""宝马"",
                ""PlusName"": ""BMW"",
                ""Country"": ""德国"",
                ""Category"": ""Car"",
                ""Grade"": 1,
                ""Tip"": ""德系三大豪华品牌之一""
              },
              {
                ""ID"": 6,
                ""Name"": ""比亚迪"",
                ""KeyName"": ""比亚迪"",
                ""PlusName"": ""BYD"",
                ""Country"": ""中国"",
                ""Category"": ""Car"",
                ""Grade"": 1,
                ""Tip"": ""全球最大充电电池生产商""
              },
              {
                ""ID"": 7,
                ""Name"": ""必胜客"",
                ""KeyName"": ""必胜客"",
                ""PlusName"": ""PizzaHut"",
                ""Country"": ""美国"",
                ""Category"": ""Cater"",
                ""Grade"": 1,
                ""Tip"": ""世界第一大披萨品牌""
              },
              {
                ""ID"": 8,
                ""Name"": ""大众"",
                ""KeyName"": ""大众"",
                ""PlusName"": ""Volkswagen"",
                ""Country"": ""德国"",
                ""Category"": ""Car"",
                ""Grade"": 1,
                ""Tip"": ""世界四大汽车生产商之一，简称VW""
              },
              {
                ""ID"": 9,
                ""Name"": ""京东"",
                ""KeyName"": ""京东"",
                ""PlusName"": ""JD"",
                ""Country"": ""中国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 1,
                ""Tip"": ""中国第一个成功赴美上市的大型综合型电商平台""
              },
              {
                ""ID"": 10,
                ""Name"": ""李宁"",
                ""KeyName"": ""李宁"",
                ""PlusName"": ""LINING"",
                ""Country"": ""中国"",
                ""Category"": ""Fashion"",
                ""Grade"": 1,
                ""Tip"": ""中国体操王子以其姓名创立的运动品牌""
              },
              {
                ""ID"": 11,
                ""Name"": ""耐克"",
                ""KeyName"": ""耐克"",
                ""PlusName"": ""NIKE"",
                ""Country"": ""美国"",
                ""Category"": ""Fashion"",
                ""Grade"": 1,
                ""Tip"": ""全球著名的体育运动品牌，口号：Just do it""
              },
              {
                ""ID"": 12,
                ""Name"": ""苹果"",
                ""KeyName"": ""苹果"",
                ""PlusName"": ""Apple"",
                ""Country"": ""美国"",
                ""Category"": ""Tech"",
                ""Grade"": 1,
                ""Tip"": ""世界最具价值品牌，著名手机品牌为iphone""
              },
              {
                ""ID"": 13,
                ""Name"": ""顺丰速运"",
                ""KeyName"": ""顺丰"",
                ""PlusName"": ""S.F."",
                ""Country"": ""中国"",
                ""Category"": ""Walking"",
                ""Grade"": 1,
                ""Tip"": ""国速递行业中投递速度最快的快递公司之一，创始人：王卫""
              },
              {
                ""ID"": 14,
                ""Name"": ""天猫"",
                ""KeyName"": ""天猫"",
                ""PlusName"": ""Tmall"",
                ""Country"": ""中国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 1,
                ""Tip"": ""原名淘宝商城，隶属于阿里巴巴旗下""
              },
              {
                ""ID"": 15,
                ""Name"": ""土豆网"",
                ""KeyName"": ""土豆"",
                ""PlusName"": ""Tudou"",
                ""Country"": ""中国"",
                ""Category"": ""AV"",
                ""Grade"": 1,
                ""Tip"": ""全球最早上线的视频网站之一，现与优酷合并""
              },
              {
                ""ID"": 16,
                ""Name"": ""微信"",
                ""KeyName"": ""微信"",
                ""PlusName"": ""WeChat"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 1,
                ""Tip"": ""亚洲最大用户群体的移动即时通讯软件，著名功能：朋友圈""
              },
              {
                ""ID"": 17,
                ""Name"": ""新浪微博"",
                ""KeyName"": ""微博"",
                ""PlusName"": ""Weibo"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 1,
                ""Tip"": ""新浪网推出，提供微型博客服务类的社交网站""
              },
              {
                ""ID"": 18,
                ""Name"": ""星巴克"",
                ""KeyName"": ""星巴克"",
                ""PlusName"": ""Starbucks"",
                ""Country"": ""美国"",
                ""Category"": ""Cater"",
                ""Grade"": 1,
                ""Tip"": ""全球最大的咖啡连锁店""
              },
              {
                ""ID"": 19,
                ""Name"": ""优酷"",
                ""KeyName"": ""优酷"",
                ""PlusName"": ""Youku"",
                ""Country"": ""中国"",
                ""Category"": ""AV"",
                ""Grade"": 1,
                ""Tip"": ""中国领先的视频分享网站，曾于土豆网合并""
              },
              {
                ""ID"": 20,
                ""Name"": ""圆通"",
                ""KeyName"": ""圆通"",
                ""PlusName"": ""YTO"",
                ""Country"": ""中国"",
                ""Category"": ""Walking"",
                ""Grade"": 1,
                ""Tip"": ""国内大型民营快递品牌企业、2016年借壳大杨创世上市""
              },
              {
                ""ID"": 21,
                ""Name"": ""支付宝钱包"",
                ""KeyName"": ""支付宝"",
                ""PlusName"": ""Alipay"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 1,
                ""Tip"": ""阿里巴巴旗下全球第一的移动支付平台""
              },
              {
                ""ID"": 22,
                ""Name"": ""中国工商银行"",
                ""KeyName"": ""工行"",
                ""PlusName"": ""ICBC"",
                ""Country"": ""中国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 1,
                ""Tip"": ""中国五大银行之首""
              },
              {
                ""ID"": 23,
                ""Name"": ""中国建设银行"",
                ""KeyName"": ""建行"",
                ""PlusName"": ""CCB"",
                ""Country"": ""中国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 1,
                ""Tip"": ""中国五大银行之一，缩写为CCB""
              },
              {
                ""ID"": 24,
                ""Name"": ""中国联通"",
                ""KeyName"": ""联通"",
                ""PlusName"": ""China Unicom"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 1,
                ""Tip"": ""中国唯一一家在纽约、香港、上海三地同时上市的电信运营企业""
              },
              {
                ""ID"": 25,
                ""Name"": ""中国移动"",
                ""KeyName"": ""移动"",
                ""PlusName"": ""China Mobile"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 1,
                ""Tip"": ""中国三大运营商份额居首""
              },
              {
                ""ID"": 26,
                ""Name"": ""中国一汽"",
                ""KeyName"": ""一汽"",
                ""PlusName"": ""FAW"",
                ""Country"": ""中国"",
                ""Category"": ""Car"",
                ""Grade"": 1,
                ""Tip"": ""中央直属国有特大型汽车生产企业""
              },
              {
                ""ID"": 27,
                ""Name"": ""花花公子"",
                ""KeyName"": ""花花公子"",
                ""PlusName"": ""Playboy"",
                ""Country"": ""美国"",
                ""Category"": ""Fashion"",
                ""Grade"": 1,
                ""Tip"": ""创始人：休·赫夫纳""
              },
              {
                ""ID"": 28,
                ""Name"": ""滴滴出行"",
                ""KeyName"": ""滴滴"",
                ""PlusName"": ""Didi"",
                ""Country"": ""中国"",
                ""Category"": ""Walking"",
                ""Grade"": 1,
                ""Tip"": ""涵盖出租车、专车、快车、顺风车、代驾等业务的出行平台""
              },
              {
                ""ID"": 29,
                ""Name"": ""中央电视台"",
                ""KeyName"": ""央视"",
                ""PlusName"": ""CCTV"",
                ""Country"": ""中国"",
                ""Category"": ""AV"",
                ""Grade"": 1,
                ""Tip"": ""新闻联播、春晚等节目，中国人最熟悉的电视台""
              },
              {
                ""ID"": 30,
                ""Name"": ""湖南卫视"",
                ""KeyName"": ""湖南"",
                ""PlusName"": ""Hunan Satellite TV"",
                ""Country"": ""中国"",
                ""Category"": ""AV"",
                ""Grade"": 1,
                ""Tip"": ""代表节目：快乐大本营、天天向上""
              },
              {
                ""ID"": 31,
                ""Name"": ""魅族"",
                ""KeyName"": ""魅族"",
                ""PlusName"": ""Meizu"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 1,
                ""Tip"": ""国内外知名智能手机厂商，创始人：黄章、白永祥""
              },
              {
                ""ID"": 32,
                ""Name"": ""海尔"",
                ""KeyName"": ""海尔"",
                ""PlusName"": ""Haier"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 1,
                ""Tip"": ""全球大型家电第一品牌""
              },
              {
                ""ID"": 33,
                ""Name"": ""TCL"",
                ""KeyName"": ""TCL"",
                ""PlusName"": ""-"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 1,
                ""Tip"": ""口号：廉洁奉公、思想统一、雷厉风行、富有成效""
              },
              {
                ""ID"": 34,
                ""Name"": ""361度"",
                ""KeyName"": ""361度"",
                ""PlusName"": ""361°"",
                ""Country"": ""中国"",
                ""Category"": ""Fashion"",
                ""Grade"": 2,
                ""Tip"": ""中国领先的运动品牌，口号：多一度热爱""
              },
              {
                ""ID"": 35,
                ""Name"": ""7-11"",
                ""KeyName"": ""711"",
                ""PlusName"": ""7-ELEVEN"",
                ""Country"": ""日本"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 2,
                ""Tip"": ""全球最大连锁店体系，创始人铃木敏文""
              },
              {
                ""ID"": 36,
                ""Name"": ""A站"",
                ""KeyName"": ""A站"",
                ""PlusName"": ""AcFun"",
                ""Country"": ""中国"",
                ""Category"": ""AV"",
                ""Grade"": 2,
                ""Tip"": ""中国大陆第一家弹幕视频网站，中国二次元文化的开创者、引领者""
              },
              {
                ""ID"": 37,
                ""Name"": ""阿迪达斯"",
                ""KeyName"": ""阿迪达斯"",
                ""PlusName"": ""adidas"",
                ""Country"": ""德国"",
                ""Category"": ""Fashion"",
                ""Grade"": 2,
                ""Tip"": ""德国著名运动品牌的运动表现系列""
              },
              {
                ""ID"": 38,
                ""Name"": ""爱奇艺"",
                ""KeyName"": ""爱奇艺"",
                ""PlusName"": ""iQIYI"",
                ""Country"": ""中国"",
                ""Category"": ""AV"",
                ""Grade"": 2,
                ""Tip"": ""中国视频网站，口号：悦享品质""
              },
              {
                ""ID"": 39,
                ""Name"": ""安踏"",
                ""KeyName"": ""安踏"",
                ""PlusName"": ""ANTA"",
                ""Country"": ""中国"",
                ""Category"": ""Fashion"",
                ""Grade"": 2,
                ""Tip"": ""中国领先的体育用品品牌，口号：永不止步""
              },
              {
                ""ID"": 40,
                ""Name"": ""霸王"",
                ""KeyName"": ""霸王"",
                ""PlusName"": ""-"",
                ""Country"": ""中国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 2,
                ""Tip"": ""中药世家研制，成龙代言（duang）""
              },
              {
                ""ID"": 41,
                ""Name"": ""百世汇通"",
                ""KeyName"": ""百世"",
                ""PlusName"": ""BEST"",
                ""Country"": ""中国"",
                ""Category"": ""Walking"",
                ""Grade"": 2,
                ""Tip"": ""口号：承载寄托、全程呵护""
              },
              {
                ""ID"": 42,
                ""Name"": ""本田"",
                ""KeyName"": ""本田"",
                ""PlusName"": ""HONDA"",
                ""Country"": ""日本"",
                ""Category"": ""Car"",
                ""Grade"": 2,
                ""Tip"": ""日本汽车品牌，也是世界上最大的摩托车生产厂家""
              },
              {
                ""ID"": 43,
                ""Name"": ""必胜宅急送"",
                ""KeyName"": ""必胜宅急送"",
                ""PlusName"": ""-"",
                ""Country"": ""中国"",
                ""Category"": ""Cater"",
                ""Grade"": 2,
                ""Tip"": ""百胜（中国）的必胜客衍生的独立品牌""
              },
              {
                ""ID"": 44,
                ""Name"": ""哔哩哔哩"",
                ""KeyName"": ""B站"",
                ""PlusName"": ""Bilibili"",
                ""Country"": ""中国"",
                ""Category"": ""AV"",
                ""Grade"": 2,
                ""Tip"": ""国内最大的年轻人潮流文化娱乐社区""
              },
              {
                ""ID"": 45,
                ""Name"": ""东方既白"",
                ""KeyName"": ""东方既白"",
                ""PlusName"": ""-"",
                ""Country"": ""中国"",
                ""Category"": ""Cater"",
                ""Grade"": 2,
                ""Tip"": ""百胜旗下第一个中式餐饮品牌""
              },
              {
                ""ID"": 46,
                ""Name"": ""丰田"",
                ""KeyName"": ""丰田"",
                ""PlusName"": ""TOYATA"",
                ""Country"": ""日本"",
                ""Category"": ""Car"",
                ""Grade"": 2,
                ""Tip"": ""日本最大的汽车公司""
              },
              {
                ""ID"": 47,
                ""Name"": ""黑人"",
                ""KeyName"": ""黑人"",
                ""PlusName"": ""DARLIE"",
                ""Country"": ""中国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 2,
                ""Tip"": ""一直被当作是国外的牙膏品牌""
              },
              {
                ""ID"": 48,
                ""Name"": ""红旗"",
                ""KeyName"": ""红旗"",
                ""PlusName"": ""-"",
                ""Country"": ""中国"",
                ""Category"": ""Car"",
                ""Grade"": 2,
                ""Tip"": ""中国国宾车、领导人座驾""
              },
              {
                ""ID"": 49,
                ""Name"": ""宏碁"",
                ""KeyName"": ""宏碁"",
                ""PlusName"": ""acer"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 2,
                ""Tip"": ""全球第四大个人电脑制造商""
              },
              {
                ""ID"": 50,
                ""Name"": ""华硕"",
                ""KeyName"": ""华硕"",
                ""PlusName"": ""ASUS"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 2,
                ""Tip"": ""全球第一大主板生产商""
              },
              {
                ""ID"": 51,
                ""Name"": ""佳能"",
                ""KeyName"": ""佳能"",
                ""PlusName"": ""Canon"",
                ""Country"": ""日本"",
                ""Category"": ""Tech"",
                ""Grade"": 2,
                ""Tip"": ""占有率排名第一的相机品牌""
              },
              {
                ""ID"": 52,
                ""Name"": ""康师傅"",
                ""KeyName"": ""康师傅"",
                ""PlusName"": ""-"",
                ""Country"": ""中国"",
                ""Category"": ""Cater"",
                ""Grade"": 2,
                ""Tip"": ""国内排名第一的方便面品牌，现属于顶新集团""
              },
              {
                ""ID"": 53,
                ""Name"": ""可口可乐"",
                ""KeyName"": ""可口可乐"",
                ""PlusName"": ""Coca-Cola"",
                ""Country"": ""美国"",
                ""Category"": ""Cater"",
                ""Grade"": 2,
                ""Tip"": ""全球最大的饮料厂商""
              },
              {
                ""ID"": 54,
                ""Name"": ""肯德基"",
                ""KeyName"": ""肯德基"",
                ""PlusName"": ""KFC"",
                ""Country"": ""美国"",
                ""Category"": ""Cater"",
                ""Grade"": 2,
                ""Tip"": ""世界第二大速食及最大炸鸡连锁企业""
              },
              {
                ""ID"": 55,
                ""Name"": ""麦当劳"",
                ""KeyName"": ""麦当劳"",
                ""PlusName"": ""McDonald\u0027s"",
                ""Country"": ""美国"",
                ""Category"": ""Cater"",
                ""Grade"": 2,
                ""Tip"": ""世界第一大速食企业""
              },
              {
                ""ID"": 56,
                ""Name"": ""蒙牛"",
                ""KeyName"": ""蒙牛"",
                ""PlusName"": ""MENGNIU"",
                ""Country"": ""中国"",
                ""Category"": ""Cater"",
                ""Grade"": 2,
                ""Tip"": ""中国奶制品营业额第二""
              },
              {
                ""ID"": 57,
                ""Name"": ""诺基亚"",
                ""KeyName"": ""诺基亚"",
                ""PlusName"": ""Nokia"",
                ""Country"": ""芬兰"",
                ""Category"": ""Tech"",
                ""Grade"": 2,
                ""Tip"": ""曾是手机界的王者，后与微软合作Windows Phone手机""
              },
              {
                ""ID"": 58,
                ""Name"": ""去哪儿"",
                ""KeyName"": ""去哪儿"",
                ""PlusName"": ""Qunar"",
                ""Country"": ""中国"",
                ""Category"": ""Walking"",
                ""Grade"": 2,
                ""Tip"": ""中文在线旅行网站，现与携程网合并""
              },
              {
                ""ID"": 59,
                ""Name"": ""申通"",
                ""KeyName"": ""申通"",
                ""PlusName"": ""STO"",
                ""Country"": ""中国"",
                ""Category"": ""Walking"",
                ""Grade"": 2,
                ""Tip"": ""口号：对客户满意的承诺，是xx坚定的信仰""
              },
              {
                ""ID"": 60,
                ""Name"": ""舒肤佳"",
                ""KeyName"": ""舒肤佳"",
                ""PlusName"": ""Safeguard"",
                ""Country"": ""美国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 2,
                ""Tip"": ""宝洁旗下著名的个人清洁护理品牌""
              },
              {
                ""ID"": 61,
                ""Name"": ""腾讯"",
                ""KeyName"": ""腾讯"",
                ""PlusName"": ""Tencent"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 2,
                ""Tip"": ""中国四大门户网站之一，推出有QQ、微信等社交工具""
              },
              {
                ""ID"": 62,
                ""Name"": ""小米"",
                ""KeyName"": ""小米"",
                ""PlusName"": ""MI"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 2,
                ""Tip"": ""移动互联网公司，产品概念为：为发烧而生""
              },
              {
                ""ID"": 63,
                ""Name"": ""迅雷"",
                ""KeyName"": ""迅雷"",
                ""PlusName"": ""Thunder"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 2,
                ""Tip"": ""旗下有中国使用最多的下载软件""
              },
              {
                ""ID"": 64,
                ""Name"": ""韵达"",
                ""KeyName"": ""韵达"",
                ""PlusName"": ""YUNDA"",
                ""Country"": ""中国"",
                ""Category"": ""Walking"",
                ""Grade"": 2,
                ""Tip"": ""快递企业、董事长：聂腾云""
              },
              {
                ""ID"": 65,
                ""Name"": ""中国电信"",
                ""KeyName"": ""电信"",
                ""PlusName"": ""China Telecom"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 2,
                ""Tip"": ""中国三大运营商之一，旗下有天翼品牌""
              },
              {
                ""ID"": 66,
                ""Name"": ""中国农业银行"",
                ""KeyName"": ""农行"",
                ""PlusName"": ""ABC"",
                ""Country"": ""中国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 2,
                ""Tip"": ""中国五大银行之一，缩写为ABC""
              },
              {
                ""ID"": 67,
                ""Name"": ""中通"",
                ""KeyName"": ""中通"",
                ""PlusName"": ""ZTO"",
                ""Country"": ""中国"",
                ""Category"": ""Walking"",
                ""Grade"": 2,
                ""Tip"": ""口号：誉满中华、通达天下""
              },
              {
                ""ID"": 68,
                ""Name"": ""东风"",
                ""KeyName"": ""东风"",
                ""PlusName"": ""Dongfeng"",
                ""Country"": ""中国"",
                ""Category"": ""Car"",
                ""Grade"": 2,
                ""Tip"": ""中国四大汽车集团之一，中重卡、SUV、中客排名第一位""
              },
              {
                ""ID"": 69,
                ""Name"": ""吉利"",
                ""KeyName"": ""吉利"",
                ""PlusName"": ""GEELY"",
                ""Country"": ""中国"",
                ""Category"": ""Car"",
                ""Grade"": 2,
                ""Tip"": ""中国民营汽车品牌，曾收购沃尔沃，口号：让世界充满xx！""
              },
              {
                ""ID"": 70,
                ""Name"": ""长安汽车"",
                ""KeyName"": ""长安"",
                ""PlusName"": ""CHANGAN"",
                ""Country"": ""中国"",
                ""Category"": ""Car"",
                ""Grade"": 2,
                ""Tip"": ""总部位于重庆市，口号：科技创新，关爱永恒""
              },
              {
                ""ID"": 71,
                ""Name"": ""北京汽车"",
                ""KeyName"": ""北京"",
                ""PlusName"": ""BAIC"",
                ""Country"": ""中国"",
                ""Category"": ""Car"",
                ""Grade"": 2,
                ""Tip"": ""以中国首都命名的汽车品牌""
              },
              {
                ""ID"": 72,
                ""Name"": ""飘柔"",
                ""KeyName"": ""飘柔"",
                ""PlusName"": ""Rejoice"",
                ""Country"": ""美国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 2,
                ""Tip"": ""宝洁旗下品牌：xx，顺间心动""
              },
              {
                ""ID"": 73,
                ""Name"": ""超威半导体"",
                ""KeyName"": ""AMD"",
                ""PlusName"": ""AMD"",
                ""Country"": ""美国"",
                ""Category"": ""Tech"",
                ""Grade"": 2,
                ""Tip"": ""著名微处理器提供商，口号：成就今日，启迪未来""
              },
              {
                ""ID"": 74,
                ""Name"": ""无印良品"",
                ""KeyName"": ""无印良品"",
                ""PlusName"": ""MUJI"",
                ""Country"": ""日本"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 2,
                ""Tip"": ""日本杂货品牌，包装与产品设计上皆无品牌标志""
              },
              {
                ""ID"": 75,
                ""Name"": ""与狼共舞"",
                ""KeyName"": ""与狼共舞"",
                ""PlusName"": ""DANCING WOLVES"",
                ""Country"": ""中国"",
                ""Category"": ""Fashion"",
                ""Grade"": 2,
                ""Tip"": ""七匹狼旗下品牌，灵感来源于1990来同名奥斯卡影片""
              },
              {
                ""ID"": 76,
                ""Name"": ""娃哈哈"",
                ""KeyName"": ""娃哈哈"",
                ""PlusName"": ""WAHAHA"",
                ""Country"": ""中国"",
                ""Category"": ""Cater"",
                ""Grade"": 2,
                ""Tip"": ""中国最大全球第五的食品饮料生产企业""
              },
              {
                ""ID"": 77,
                ""Name"": ""北京电视台"",
                ""KeyName"": ""北京卫视"",
                ""PlusName"": ""BTV"",
                ""Country"": ""中国"",
                ""Category"": ""AV"",
                ""Grade"": 2,
                ""Tip"": ""\""\""\""首都\""\""电视台\""""
              },
              {
                ""ID"": 78,
                ""Name"": ""搜狐视频"",
                ""KeyName"": ""搜狐视频"",
                ""PlusName"": ""-"",
                ""Country"": ""中国"",
                ""Category"": ""AV"",
                ""Grade"": 2,
                ""Tip"": ""中国第一家以正版高清长视频为显著优势的综合视频网站""
              },
              {
                ""ID"": 79,
                ""Name"": ""国家电网"",
                ""KeyName"": ""国家电网"",
                ""PlusName"": ""State Grid"",
                ""Country"": ""中国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 2,
                ""Tip"": ""全球最大的公用事业企业，口号：你用电，我用心""
              },
              {
                ""ID"": 80,
                ""Name"": ""中国邮政储蓄银行"",
                ""KeyName"": ""邮政储蓄"",
                ""PlusName"": ""PSBC"",
                ""Country"": ""中国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 2,
                ""Tip"": ""中国邮政集团公司下的商业银行""
              },
              {
                ""ID"": 81,
                ""Name"": ""大嘴猴"",
                ""KeyName"": ""大嘴猴"",
                ""PlusName"": ""Paul Frank"",
                ""Country"": ""美国"",
                ""Category"": ""Fashion"",
                ""Grade"": 2,
                ""Tip"": ""色彩缤纷、年轻、可爱、时尚感，由橘子郡起步""
              },
              {
                ""ID"": 82,
                ""Name"": ""红牛"",
                ""KeyName"": ""红牛"",
                ""PlusName"": ""Red Bull"",
                ""Country"": ""中国"",
                ""Category"": ""Cater"",
                ""Grade"": 2,
                ""Tip"": ""维他命饮料，口号：你的能量，超乎你想象""
              },
              {
                ""ID"": 83,
                ""Name"": ""骆驼"",
                ""KeyName"": ""骆驼"",
                ""PlusName"": ""CAMEL"",
                ""Country"": ""美国"",
                ""Category"": ""Fashion"",
                ""Grade"": 2,
                ""Tip"": ""美国驰名品牌，灵感来自沙漠中的一种动物""
              },
              {
                ""ID"": 84,
                ""Name"": ""OPPO"",
                ""KeyName"": ""OPPO"",
                ""PlusName"": ""欧珀"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 2,
                ""Tip"": ""口号：至美，所品不凡""
              },
              {
                ""ID"": 85,
                ""Name"": ""vivo"",
                ""KeyName"": ""vivo"",
                ""PlusName"": ""维沃"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 2,
                ""Tip"": ""其手机产品主打Hi-Fi音效，推出Funtouch OS操作系统""
              },
              {
                ""ID"": 86,
                ""Name"": ""56网"",
                ""KeyName"": ""56"",
                ""PlusName"": ""我乐"",
                ""Country"": ""中国"",
                ""Category"": ""AV"",
                ""Grade"": 2,
                ""Tip"": ""视频分享网站，口号：分享视频，分享快乐""
              },
              {
                ""ID"": 87,
                ""Name"": ""CW"",
                ""KeyName"": ""CW"",
                ""PlusName"": ""-"",
                ""Country"": ""美国"",
                ""Category"": ""AV"",
                ""Grade"": 2,
                ""Tip"": ""由哥伦比亚广播公司及华纳兄弟共同出资的电视公共网""
              },
              {
                ""ID"": 88,
                ""Name"": ""海信"",
                ""KeyName"": ""海信"",
                ""PlusName"": ""Hisense"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 2,
                ""Tip"": ""旗下拥有科龙、容声等中国著名商标""
              },
              {
                ""ID"": 89,
                ""Name"": ""创维"",
                ""KeyName"": ""创维"",
                ""PlusName"": ""Skyworth"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 2,
                ""Tip"": ""口号：专注健康科技""
              },
              {
                ""ID"": 90,
                ""Name"": ""海澜之家"",
                ""KeyName"": ""海澜之家"",
                ""PlusName"": ""heilanhome"",
                ""Country"": ""中国"",
                ""Category"": ""Fashion"",
                ""Grade"": 2,
                ""Tip"": ""口号：男人的衣柜""
              },
              {
                ""ID"": 91,
                ""Name"": ""蓝月亮"",
                ""KeyName"": ""蓝月亮"",
                ""PlusName"": ""-"",
                ""Country"": ""中国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 2,
                ""Tip"": ""中国洗衣液市场领导品牌，洗衣液连续五年市场份额第一""
              },
              {
                ""ID"": 92,
                ""Name"": ""H\u0026M"",
                ""KeyName"": ""H\u0026M"",
                ""PlusName"": ""-"",
                ""Country"": ""瑞典"",
                ""Category"": ""Fashion"",
                ""Grade"": 3,
                ""Tip"": ""来自于瑞典的世界知名服装商""
              },
              {
                ""ID"": 93,
                ""Name"": ""Jeep"",
                ""KeyName"": ""Jeep"",
                ""PlusName"": ""-"",
                ""Country"": ""美国"",
                ""Category"": ""Car"",
                ""Grade"": 3,
                ""Tip"": ""经典广告词：不是所有的吉普都叫XXX""
              },
              {
                ""ID"": 94,
                ""Name"": ""LG"",
                ""KeyName"": ""LG"",
                ""PlusName"": ""-"",
                ""Country"": ""韩国"",
                ""Category"": ""Tech"",
                ""Grade"": 3,
                ""Tip"": ""韩国电子业第二大集团""
              },
              {
                ""ID"": 95,
                ""Name"": ""TP-LINK"",
                ""KeyName"": ""TPLINK"",
                ""PlusName"": ""普联"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 3,
                ""Tip"": ""普联旗下享誉全国的知名网络与通信品牌""
              },
              {
                ""ID"": 96,
                ""Name"": ""YouTube"",
                ""KeyName"": ""YouTube"",
                ""PlusName"": ""-"",
                ""Country"": ""美国"",
                ""Category"": ""AV"",
                ""Grade"": 3,
                ""Tip"": ""世界上最大的视频网站，现属谷歌""
              },
              {
                ""ID"": 97,
                ""Name"": ""ZARA"",
                ""KeyName"": ""ZARA"",
                ""PlusName"": ""-"",
                ""Country"": ""西班牙"",
                ""Category"": ""Fashion"",
                ""Grade"": 3,
                ""Tip"": ""西班牙排名第一、全球排名第三的服装商""
              },
              {
                ""ID"": 98,
                ""Name"": ""安卓"",
                ""KeyName"": ""安卓"",
                ""PlusName"": ""Android"",
                ""Country"": ""美国"",
                ""Category"": ""Tech"",
                ""Grade"": 3,
                ""Tip"": ""Google公司开发的移动操作系统""
              },
              {
                ""ID"": 99,
                ""Name"": ""百事可乐"",
                ""KeyName"": ""百事可乐"",
                ""PlusName"": ""Pepsi Cola"",
                ""Country"": ""美国"",
                ""Category"": ""Cater"",
                ""Grade"": 3,
                ""Tip"": ""碳酸饮料，可口可乐的主要竞争对手""
              },
              {
                ""ID"": 100,
                ""Name"": ""奔驰"",
                ""KeyName"": ""奔驰"",
                ""PlusName"": ""Mercedes-Benz"",
                ""Country"": ""德国"",
                ""Category"": ""Car"",
                ""Grade"": 3,
                ""Tip"": ""三叉星标志，德国高档汽车品牌""
              },
              {
                ""ID"": 101,
                ""Name"": ""标致"",
                ""KeyName"": ""标致"",
                ""PlusName"": ""PEUGEOT"",
                ""Country"": ""法国"",
                ""Category"": ""Car"",
                ""Grade"": 3,
                ""Tip"": ""与雪铁龙同属欧洲第二大汽车制造集团旗下""
              },
              {
                ""ID"": 102,
                ""Name"": ""彪马"",
                ""KeyName"": ""彪马"",
                ""PlusName"": ""PUMA"",
                ""Country"": ""德国"",
                ""Category"": ""Fashion"",
                ""Grade"": 3,
                ""Tip"": ""德国著名运动品牌，口号：Forever Faster""
              },
              {
                ""ID"": 103,
                ""Name"": ""戴尔"",
                ""KeyName"": ""戴尔"",
                ""PlusName"": ""DELL"",
                ""Country"": ""美国"",
                ""Category"": ""Tech"",
                ""Grade"": 3,
                ""Tip"": ""口号：The power to do more(激发无限)""
              },
              {
                ""ID"": 104,
                ""Name"": ""稻草人"",
                ""KeyName"": ""稻草人"",
                ""PlusName"": ""MEXICAN"",
                ""Country"": ""美国"",
                ""Category"": ""Fashion"",
                ""Grade"": 3,
                ""Tip"": ""北美男士著名时装品牌，创始人：弗瑞达""
              },
              {
                ""ID"": 105,
                ""Name"": ""德克士"",
                ""KeyName"": ""德克士"",
                ""PlusName"": ""dicos"",
                ""Country"": ""中国"",
                ""Category"": ""Cater"",
                ""Grade"": 3,
                ""Tip"": ""中国西式快餐特许加盟第一品牌""
              },
              {
                ""ID"": 106,
                ""Name"": ""东芝"",
                ""KeyName"": ""东芝"",
                ""PlusName"": ""Toshiba"",
                ""Country"": ""日本"",
                ""Category"": ""Tech"",
                ""Grade"": 3,
                ""Tip"": ""日本最大的半导体制造商""
              },
              {
                ""ID"": 107,
                ""Name"": ""飞信"",
                ""KeyName"": ""飞信"",
                ""PlusName"": ""Fetion"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 3,
                ""Tip"": ""中国移动推出的综合通信服务""
              },
              {
                ""ID"": 108,
                ""Name"": ""谷歌"",
                ""KeyName"": ""谷歌"",
                ""PlusName"": ""Google"",
                ""Country"": ""美国"",
                ""Category"": ""Tech"",
                ""Grade"": 3,
                ""Tip"": ""旗下拥有全球最大的搜索引擎""
              },
              {
                ""ID"": 109,
                ""Name"": ""黑莓"",
                ""KeyName"": ""黑莓"",
                ""PlusName"": ""BlackBerry"",
                ""Country"": ""加拿大"",
                ""Category"": ""Tech"",
                ""Grade"": 3,
                ""Tip"": ""其手机产品往往配备有QWERTY全键盘""
              },
              {
                ""ID"": 110,
                ""Name"": ""宏达"",
                ""KeyName"": ""宏达"",
                ""PlusName"": ""HTC"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 3,
                ""Tip"": ""全球最大的智能手机代工和生产厂商""
              },
              {
                ""ID"": 111,
                ""Name"": ""鸿星尔克"",
                ""KeyName"": ""鸿星尔克"",
                ""PlusName"": ""ERKE"",
                ""Country"": ""中国"",
                ""Category"": ""Fashion"",
                ""Grade"": 3,
                ""Tip"": ""口号：TO BE No.1""
              },
              {
                ""ID"": 112,
                ""Name"": ""惠普"",
                ""KeyName"": ""惠普"",
                ""PlusName"": ""HP"",
                ""Country"": ""美国"",
                ""Category"": ""Tech"",
                ""Grade"": 3,
                ""Tip"": ""世界最大的IT公司之一，曾收购康柏电脑""
              },
              {
                ""ID"": 113,
                ""Name"": ""7天连锁酒店"",
                ""KeyName"": ""7天连锁"",
                ""PlusName"": ""7 days Inn"",
                ""Country"": ""中国"",
                ""Category"": ""Walking"",
                ""Grade"": 3,
                ""Tip"": ""隶属于铂涛酒店，中国经济型酒店行业的第一品牌""
              },
              {
                ""ID"": 114,
                ""Name"": ""卡帕"",
                ""KeyName"": ""卡帕"",
                ""PlusName"": ""kappa"",
                ""Country"": ""意大利"",
                ""Category"": ""Fashion"",
                ""Grade"": 3,
                ""Tip"": ""在中国常误译为：背靠背""
              },
              {
                ""ID"": 115,
                ""Name"": ""联邦快递"",
                ""KeyName"": ""联邦"",
                ""PlusName"": ""FedEx"",
                ""Country"": ""美国"",
                ""Category"": ""Walking"",
                ""Grade"": 3,
                ""Tip"": ""创始人：弗雷德史密斯，被誉为：创造了一个新行业的人""
              },
              {
                ""ID"": 116,
                ""Name"": ""联想"",
                ""KeyName"": ""联想"",
                ""PlusName"": ""Lenovo"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 3,
                ""Tip"": ""其电脑销量位居中国首位，2013年超越惠普成为全球最大的PC生产厂商""
              },
              {
                ""ID"": 117,
                ""Name"": ""路虎"",
                ""KeyName"": ""路虎"",
                ""PlusName"": ""Landrover"",
                ""Country"": ""英国"",
                ""Category"": ""Car"",
                ""Grade"": 3,
                ""Tip"": ""世界上唯一专门生产顶级全地形汽车的奢华SUV品牌""
              },
              {
                ""ID"": 118,
                ""Name"": ""路特斯"",
                ""KeyName"": ""路特斯"",
                ""PlusName"": ""Lotus"",
                ""Country"": ""英国"",
                ""Category"": ""Car"",
                ""Grade"": 3,
                ""Tip"": ""世界三大跑车制造商之一，曾译为：莲花汽车""
              },
              {
                ""ID"": 119,
                ""Name"": ""漫威"",
                ""KeyName"": ""漫威"",
                ""PlusName"": ""Marvel"",
                ""Country"": ""美国"",
                ""Category"": ""AV"",
                ""Grade"": 3,
                ""Tip"": ""美国漫画巨头，旗下有蜘蛛侠、美国队长等角色""
              },
              {
                ""ID"": 120,
                ""Name"": ""美的"",
                ""KeyName"": ""美的"",
                ""PlusName"": ""Midea"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 3,
                ""Tip"": ""口号：原来生活可以更美的""
              },
              {
                ""ID"": 121,
                ""Name"": ""摩托罗拉"",
                ""KeyName"": ""摩托罗拉"",
                ""PlusName"": ""Motorola"",
                ""Country"": ""美国"",
                ""Category"": ""Tech"",
                ""Grade"": 3,
                ""Tip"": ""全球芯片制造、电子通讯的领导者，其移动业务先后被谷歌和联想收购""
              },
              {
                ""ID"": 122,
                ""Name"": ""尼康"",
                ""KeyName"": ""尼康"",
                ""PlusName"": ""Nicon"",
                ""Country"": ""日本"",
                ""Category"": ""Tech"",
                ""Grade"": 3,
                ""Tip"": ""日本著名相机品牌，排名仅次于佳能""
              },
              {
                ""ID"": 123,
                ""Name"": ""起亚"",
                ""KeyName"": ""起亚"",
                ""PlusName"": ""KIA"",
                ""Country"": ""韩国"",
                ""Category"": ""Car"",
                ""Grade"": 3,
                ""Tip"": ""韩国最早的汽车制造商""
              },
              {
                ""ID"": 124,
                ""Name"": ""雀巢"",
                ""KeyName"": ""雀巢"",
                ""PlusName"": ""Nestle"",
                ""Country"": ""瑞士"",
                ""Category"": ""Cater"",
                ""Grade"": 3,
                ""Tip"": ""世界上最大的食品制造商，以生产巧克力棒和速溶咖啡闻名""
              },
              {
                ""ID"": 125,
                ""Name"": ""三菱"",
                ""KeyName"": ""三菱"",
                ""PlusName"": ""Mitsubishi"",
                ""Country"": ""日本"",
                ""Category"": ""Car"",
                ""Grade"": 3,
                ""Tip"": ""日本汽车行业中最年轻的汽车制造公司""
              },
              {
                ""ID"": 126,
                ""Name"": ""三星"",
                ""KeyName"": ""三星"",
                ""PlusName"": ""Samsung"",
                ""Country"": ""韩国"",
                ""Category"": ""Tech"",
                ""Grade"": 3,
                ""Tip"": ""韩国最大的跨国企业集团""
              },
              {
                ""ID"": 127,
                ""Name"": ""交通银行"",
                ""KeyName"": ""交通银行"",
                ""PlusName"": ""BOCOM"",
                ""Country"": ""中国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 3,
                ""Tip"": ""中国近代以来延续历史最悠久、最古老的银行""
              },
              {
                ""ID"": 128,
                ""Name"": ""特步"",
                ""KeyName"": ""特步"",
                ""PlusName"": ""Xtep"",
                ""Country"": ""中国"",
                ""Category"": ""Fashion"",
                ""Grade"": 3,
                ""Tip"": ""中国时尚运动品牌，首创娱乐明星代言体育用品的全新模式""
              },
              {
                ""ID"": 129,
                ""Name"": ""天天快递"",
                ""KeyName"": ""天天"",
                ""PlusName"": ""TTK"",
                ""Country"": ""中国"",
                ""Category"": ""Walking"",
                ""Grade"": 3,
                ""Tip"": ""口号：xx快递、xx相伴""
              },
              {
                ""ID"": 130,
                ""Name"": ""新浪"",
                ""KeyName"": ""新浪"",
                ""PlusName"": ""Sina"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 3,
                ""Tip"": ""四大综合门户网站之首""
              },
              {
                ""ID"": 131,
                ""Name"": ""雪佛兰"",
                ""KeyName"": ""雪佛兰"",
                ""PlusName"": ""Chevrolet"",
                ""Country"": ""美国"",
                ""Category"": ""Car"",
                ""Grade"": 3,
                ""Tip"": ""通用汽车旗下最为国际化和大众化的汽车品牌""
              },
              {
                ""ID"": 132,
                ""Name"": ""伊利"",
                ""KeyName"": ""伊利"",
                ""PlusName"": ""Yili"",
                ""Country"": ""中国"",
                ""Category"": ""Cater"",
                ""Grade"": 3,
                ""Tip"": ""亚洲乳业第一""
              },
              {
                ""ID"": 133,
                ""Name"": ""真功夫"",
                ""KeyName"": ""真功夫"",
                ""PlusName"": ""True Kungfu"",
                ""Country"": ""中国"",
                ""Category"": ""Cater"",
                ""Grade"": 3,
                ""Tip"": ""中国快餐行业前五强中唯一的本土品牌""
              },
              {
                ""ID"": 134,
                ""Name"": ""金龙鱼"",
                ""KeyName"": ""金龙鱼"",
                ""PlusName"": ""-"",
                ""Country"": ""新加坡"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 3,
                ""Tip"": ""世界500强丰益国际旗下著名粮油品牌""
              },
              {
                ""ID"": 135,
                ""Name"": ""上汽大通"",
                ""KeyName"": ""上汽大通"",
                ""PlusName"": ""SAIC MAXUS"",
                ""Country"": ""中国"",
                ""Category"": ""Car"",
                ""Grade"": 3,
                ""Tip"": ""上汽集团旗下的传奇商用车品牌""
              },
              {
                ""ID"": 136,
                ""Name"": ""汰渍"",
                ""KeyName"": ""汰渍"",
                ""PlusName"": ""Tide"",
                ""Country"": ""美国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 3,
                ""Tip"": ""宝洁旗下著名洗涤品牌：有xx，没污渍""
              },
              {
                ""ID"": 137,
                ""Name"": ""中国银行"",
                ""KeyName"": ""中国银行"",
                ""PlusName"": ""BOC"",
                ""Country"": ""中国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 3,
                ""Tip"": ""中国五大银行之一，标志像一个中字""
              },
              {
                ""ID"": 138,
                ""Name"": ""冶天"",
                ""KeyName"": ""ATI"",
                ""PlusName"": ""ATI"",
                ""Country"": ""加拿大"",
                ""Category"": ""Tech"",
                ""Grade"": 3,
                ""Tip"": ""著名的显示芯片生产商，和NVIDIA齐名，后被AMD收购""
              },
              {
                ""ID"": 139,
                ""Name"": ""玉兰油"",
                ""KeyName"": ""OLAY"",
                ""PlusName"": ""OLAY"",
                ""Country"": ""美国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 3,
                ""Tip"": ""全球领导护肤品牌，创始人：葛拉汉伍尔夫""
              },
              {
                ""ID"": 140,
                ""Name"": ""海飞丝"",
                ""KeyName"": ""海飞丝"",
                ""PlusName"": ""Head\u0026Shoulders"",
                ""Country"": ""美国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 3,
                ""Tip"": ""宝洁旗下品牌，其产品最新研究成果：活力锌""
              },
              {
                ""ID"": 141,
                ""Name"": ""Uber"",
                ""KeyName"": ""Uber"",
                ""PlusName"": ""优步"",
                ""Country"": ""美国"",
                ""Category"": ""Walking"",
                ""Grade"": 3,
                ""Tip"": ""美国打车应用""
              },
              {
                ""ID"": 142,
                ""Name"": ""12306"",
                ""KeyName"": ""12306"",
                ""PlusName"": ""中国铁路客户服务中心"",
                ""Country"": ""中国"",
                ""Category"": ""Walking"",
                ""Grade"": 3,
                ""Tip"": ""网购火车票（P.S.最坑）的地方""
              },
              {
                ""ID"": 143,
                ""Name"": ""神州租车"",
                ""KeyName"": ""神州租车"",
                ""PlusName"": ""CAR"",
                ""Country"": ""中国"",
                ""Category"": ""Walking"",
                ""Grade"": 3,
                ""Tip"": ""口号：推动绿色出行，引领中国汽车租赁行业发展""
              },
              {
                ""ID"": 144,
                ""Name"": ""英国广播公司"",
                ""KeyName"": ""BBC"",
                ""PlusName"": ""BBC"",
                ""Country"": ""英国"",
                ""Category"": ""AV"",
                ""Grade"": 3,
                ""Tip"": ""英国最大的新闻广播机构""
              },
              {
                ""ID"": 145,
                ""Name"": ""美国有线电视新闻网"",
                ""KeyName"": ""CNN"",
                ""PlusName"": ""CNN"",
                ""Country"": ""美国"",
                ""Category"": ""AV"",
                ""Grade"": 3,
                ""Tip"": ""全天候的新闻节目，创始人：特德·特纳""
              },
              {
                ""ID"": 146,
                ""Name"": ""同程旅游"",
                ""KeyName"": ""同程"",
                ""PlusName"": ""-"",
                ""Country"": ""中国"",
                ""Category"": ""Walking"",
                ""Grade"": 3,
                ""Tip"": ""中国领先的休闲旅游在线服务商，创始人：吴志祥""
              },
              {
                ""ID"": 147,
                ""Name"": ""腾讯视频"",
                ""KeyName"": ""腾讯视频"",
                ""PlusName"": ""-"",
                ""Country"": ""中国"",
                ""Category"": ""AV"",
                ""Grade"": 3,
                ""Tip"": ""中国最大在线视频媒体平台""
              },
              {
                ""ID"": 148,
                ""Name"": ""联合利华"",
                ""KeyName"": ""联合利华"",
                ""PlusName"": ""Unilever"",
                ""Country"": ""荷兰/英国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 3,
                ""Tip"": ""荷兰人造奶油公司和英国香皂公司合并而成""
              },
              {
                ""ID"": 149,
                ""Name"": ""力士"",
                ""KeyName"": ""力士"",
                ""PlusName"": ""LUX"",
                ""Country"": ""荷兰/英国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 3,
                ""Tip"": ""联合利华旗下清洁品牌""
              },
              {
                ""ID"": 150,
                ""Name"": ""中国石油天然气集团公司"",
                ""KeyName"": ""中石油"",
                ""PlusName"": ""CNPC"",
                ""Country"": ""中国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 3,
                ""Tip"": ""中国主要的油气生产商和供应商之一，全球市值第二大的企业""
              },
              {
                ""ID"": 151,
                ""Name"": ""德芙"",
                ""KeyName"": ""德芙"",
                ""PlusName"": ""Dove"",
                ""Country"": ""美国"",
                ""Category"": ""Cater"",
                ""Grade"": 3,
                ""Tip"": ""玛氏公司在中国推出的产品：牛奶香浓，丝般感受""
              },
              {
                ""ID"": 152,
                ""Name"": ""奇瑞"",
                ""KeyName"": ""奇瑞"",
                ""PlusName"": ""Chery Automobile"",
                ""Country"": ""中国"",
                ""Category"": ""Car"",
                ""Grade"": 3,
                ""Tip"": ""xxQQ，9年蝉联中国自主品牌销量冠军""
              },
              {
                ""ID"": 153,
                ""Name"": ""长虹"",
                ""KeyName"": ""长虹"",
                ""PlusName"": ""changhong"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 3,
                ""Tip"": ""集军工、消费电子、核心器件研发与制造为一体的综合型跨国企业集团""
              },
              {
                ""ID"": 154,
                ""Name"": ""太平洋保险"",
                ""KeyName"": ""太保"",
                ""PlusName"": ""CPIC"",
                ""Country"": ""中国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 3,
                ""Tip"": ""中国大陆第二大财产保险公司""
              },
              {
                ""ID"": 155,
                ""Name"": ""中国人寿"",
                ""KeyName"": ""人寿"",
                ""PlusName"": ""China Life"",
                ""Country"": ""中国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 3,
                ""Tip"": ""我国最大的国有金融保险集团""
              },
              {
                ""ID"": 156,
                ""Name"": ""beats耳机"",
                ""KeyName"": ""Beats"",
                ""PlusName"": ""节拍"",
                ""Country"": ""美国"",
                ""Category"": ""Tech"",
                ""Grade"": 3,
                ""Tip"": ""声乐设备品牌，后苹果以30亿美元收购其相关业务""
              },
              {
                ""ID"": 157,
                ""Name"": ""杰克琼斯"",
                ""KeyName"": ""杰克琼斯"",
                ""PlusName"": ""JACK \u0026 JONES"",
                ""Country"": ""丹麦"",
                ""Category"": ""Fashion"",
                ""Grade"": 3,
                ""Tip"": ""丹麦BESTSELLER集团旗下品牌，欧式风格设计男装""
              },
              {
                ""ID"": 158,
                ""Name"": ""水星路由器"",
                ""KeyName"": ""水星"",
                ""PlusName"": ""Mercury"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 3,
                ""Tip"": ""路由器品牌，隶属深圳市美科星通信技术有限公司""
              },
              {
                ""ID"": 159,
                ""Name"": ""胜利"",
                ""KeyName"": ""威克多"",
                ""PlusName"": ""Victor"",
                ""Country"": ""中国"",
                ""Category"": ""Fashion"",
                ""Grade"": 3,
                ""Tip"": ""羽网系列用品品牌，创始人：陈登立""
              },
              {
                ""ID"": 160,
                ""Name"": ""红双喜"",
                ""KeyName"": ""红双喜"",
                ""PlusName"": ""DHS"",
                ""Country"": ""中国"",
                ""Category"": ""Fashion"",
                ""Grade"": 3,
                ""Tip"": ""第一个在世界大赛上亮相的中国体育品牌""
              },
              {
                ""ID"": 161,
                ""Name"": ""夏普"",
                ""KeyName"": ""夏普"",
                ""PlusName"": ""Sharp"",
                ""Country"": ""日本"",
                ""Category"": ""Tech"",
                ""Grade"": 3,
                ""Tip"": ""日本大型电器及电子公司，创始人：早川德次""
              },
              {
                ""ID"": 162,
                ""Name"": ""任天堂"",
                ""KeyName"": ""任天堂"",
                ""PlusName"": ""Nintendo"",
                ""Country"": ""日本"",
                ""Category"": ""AV"",
                ""Grade"": 3,
                ""Tip"": ""开发了游戏史上最热销游戏系列超级马里奥和精灵宝可梦""
              },
              {
                ""ID"": 163,
                ""Name"": ""酷派"",
                ""KeyName"": ""酷派"",
                ""PlusName"": ""Coolpad"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 3,
                ""Tip"": ""宇龙通信公司的手机品牌""
              },
              {
                ""ID"": 164,
                ""Name"": ""Adobe"",
                ""KeyName"": ""Adobe"",
                ""PlusName"": ""-"",
                ""Country"": ""美国"",
                ""Category"": ""Tech"",
                ""Grade"": 4,
                ""Tip"": ""图像元老Photoshop的开发商""
              },
              {
                ""ID"": 165,
                ""Name"": ""Cherry"",
                ""KeyName"": ""Cherry"",
                ""PlusName"": ""-"",
                ""Country"": ""德国"",
                ""Category"": ""Tech"",
                ""Grade"": 4,
                ""Tip"": ""全球数一数二的专业键盘制造厂商，以机械键盘闻名世界""
              },
              {
                ""ID"": 166,
                ""Name"": ""DC"",
                ""KeyName"": ""DC"",
                ""PlusName"": ""-"",
                ""Country"": ""美国"",
                ""Category"": ""AV"",
                ""Grade"": 4,
                ""Tip"": ""美国漫画巨头，创造出世界上第一位超级英雄：超人""
              },
              {
                ""ID"": 167,
                ""Name"": ""DHL"",
                ""KeyName"": ""DHL"",
                ""PlusName"": ""-"",
                ""Country"": ""德国"",
                ""Category"": ""Walking"",
                ""Grade"": 4,
                ""Tip"": ""德国敦豪航空货运公司旗下品牌""
              },
              {
                ""ID"": 168,
                ""Name"": ""GAP"",
                ""KeyName"": ""GAP"",
                ""PlusName"": ""盖璞"",
                ""Country"": ""美国"",
                ""Category"": ""Fashion"",
                ""Grade"": 4,
                ""Tip"": ""美国第一大服装零售品牌""
              },
              {
                ""ID"": 169,
                ""Name"": ""KTM"",
                ""KeyName"": ""KTM"",
                ""PlusName"": ""KTM"",
                ""Country"": ""奥地利"",
                ""Category"": ""Car"",
                ""Grade"": 4,
                ""Tip"": ""奥地利的摩托车制造商，世界著名的越野车开发者""
              },
              {
                ""ID"": 170,
                ""Name"": ""阿里巴巴"",
                ""KeyName"": ""阿里巴巴"",
                ""PlusName"": ""Alibaba"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 4,
                ""Tip"": ""创始人马云，目前已成为全球最大的零售交易平台""
              },
              {
                ""ID"": 171,
                ""Name"": ""奥利奥"",
                ""KeyName"": ""奥利奥"",
                ""PlusName"": ""Oreo"",
                ""Country"": ""美国"",
                ""Category"": ""Cater"",
                ""Grade"": 4,
                ""Tip"": ""全球巧克力味夹心饼干的代名词""
              },
              {
                ""ID"": 172,
                ""Name"": ""保时捷"",
                ""KeyName"": ""保时捷"",
                ""PlusName"": ""Porsche"",
                ""Country"": ""德国"",
                ""Category"": ""Car"",
                ""Grade"": 4,
                ""Tip"": ""以生产高级跑车闻名于世界车坛，又叫波尔舍""
              },
              {
                ""ID"": 173,
                ""Name"": ""宾得"",
                ""KeyName"": ""宾得"",
                ""PlusName"": ""PENTAX"",
                ""Country"": ""日本"",
                ""Category"": ""Tech"",
                ""Grade"": 4,
                ""Tip"": ""曾是旭光学公司的单反相机品牌""
              },
              {
                ""ID"": 174,
                ""Name"": ""德邦物流"",
                ""KeyName"": ""德邦"",
                ""PlusName"": ""deppon"",
                ""Country"": ""中国"",
                ""Category"": ""Walking"",
                ""Grade"": 4,
                ""Tip"": ""口号：专注你的托付""
              },
              {
                ""ID"": 175,
                ""Name"": ""迪士尼"",
                ""KeyName"": ""迪士尼"",
                ""PlusName"": ""Disney"",
                ""Country"": ""美国"",
                ""Category"": ""AV"",
                ""Grade"": 4,
                ""Tip"": ""创造了米老鼠这一举世闻名的动画形象""
              },
              {
                ""ID"": 176,
                ""Name"": ""法拉利"",
                ""KeyName"": ""法拉利"",
                ""PlusName"": ""Ferrari"",
                ""Country"": ""意大利"",
                ""Category"": ""Car"",
                ""Grade"": 4,
                ""Tip"": ""世界闻名的赛车和运动跑车的生产厂家，现属菲亚特集团""
              },
              {
                ""ID"": 177,
                ""Name"": ""飞利浦"",
                ""KeyName"": ""飞利浦"",
                ""PlusName"": ""Philips"",
                ""Country"": ""荷兰"",
                ""Category"": ""Tech"",
                ""Grade"": 4,
                ""Tip"": ""来自荷兰的世界知名电子品牌""
              },
              {
                ""ID"": 178,
                ""Name"": ""福特"",
                ""KeyName"": ""福特"",
                ""PlusName"": ""Ford"",
                ""Country"": ""美国"",
                ""Category"": ""Car"",
                ""Grade"": 4,
                ""Tip"": ""口号：进无止境""
              },
              {
                ""ID"": 179,
                ""Name"": ""格力"",
                ""KeyName"": ""格力"",
                ""PlusName"": ""GREE"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 4,
                ""Tip"": ""掌握核心科技""
              },
              {
                ""ID"": 180,
                ""Name"": ""冠捷"",
                ""KeyName"": ""冠捷"",
                ""PlusName"": ""AOC"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 4,
                ""Tip"": ""中国显示器市场销量第一""
              },
              {
                ""ID"": 181,
                ""Name"": ""国通快递"",
                ""KeyName"": ""国通"",
                ""PlusName"": ""-"",
                ""Country"": ""中国"",
                ""Category"": ""Walking"",
                ""Grade"": 4,
                ""Tip"": ""口号：为民服务、和谐万家""
              },
              {
                ""ID"": 182,
                ""Name"": ""哈根达斯"",
                ""KeyName"": ""哈根达斯"",
                ""PlusName"": ""Haagen-Dazs"",
                ""Country"": ""美国"",
                ""Category"": ""Cater"",
                ""Grade"": 4,
                ""Tip"": ""风靡全球的冰淇淋品牌""
              },
              {
                ""ID"": 183,
                ""Name"": ""华为"",
                ""KeyName"": ""华为"",
                ""PlusName"": ""HuaWei"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 4,
                ""Tip"": ""旗下有互联网手机品牌：荣耀""
              },
              {
                ""ID"": 184,
                ""Name"": ""雷克萨斯"",
                ""KeyName"": ""雷克萨斯"",
                ""PlusName"": ""LEXUS"",
                ""Country"": ""日本"",
                ""Category"": ""Car"",
                ""Grade"": 4,
                ""Tip"": ""丰田集团旗下全球著名豪华汽车品牌""
              },
              {
                ""ID"": 185,
                ""Name"": ""雷蛇"",
                ""KeyName"": ""雷蛇"",
                ""PlusName"": ""Razer"",
                ""Country"": ""美国"",
                ""Category"": ""Tech"",
                ""Grade"": 4,
                ""Tip"": ""全球顶级游戏外设品牌，宗旨是：始于玩家，赋予玩家""
              },
              {
                ""ID"": 186,
                ""Name"": ""联合包裹"",
                ""KeyName"": ""UPS"",
                ""PlusName"": ""UPS"",
                ""Country"": ""美国"",
                ""Category"": ""Walking"",
                ""Grade"": 4,
                ""Tip"": ""世界上最大的快递承运商与包裹递送公司""
              },
              {
                ""ID"": 187,
                ""Name"": ""马自达"",
                ""KeyName"": ""马自达"",
                ""PlusName"": ""MAZDA"",
                ""Country"": ""日本"",
                ""Category"": ""Car"",
                ""Grade"": 4,
                ""Tip"": ""日本第四大汽车制造商，世界上唯一研发和生产转子发动机的汽车公司""
              },
              {
                ""ID"": 188,
                ""Name"": ""美特斯邦威"",
                ""KeyName"": ""美特斯邦威"",
                ""PlusName"": ""Meters Bonwe"",
                ""Country"": ""中国"",
                ""Category"": ""Fashion"",
                ""Grade"": 4,
                ""Tip"": ""中国本土休闲服品牌，创始人：周成建""
              },
              {
                ""ID"": 189,
                ""Name"": ""梦工厂"",
                ""KeyName"": ""梦工厂"",
                ""PlusName"": ""DreamWorks"",
                ""Country"": ""美国"",
                ""Category"": ""AV"",
                ""Grade"": 4,
                ""Tip"": ""电影公司，创始人之一为史蒂文·斯皮尔伯格""
              },
              {
                ""ID"": 190,
                ""Name"": ""讴歌"",
                ""KeyName"": ""讴歌"",
                ""PlusName"": ""Acura"",
                ""Country"": ""日本"",
                ""Category"": ""Car"",
                ""Grade"": 4,
                ""Tip"": ""本田旗下高端子品牌，口号：专注驰骋""
              },
              {
                ""ID"": 191,
                ""Name"": ""匹克"",
                ""KeyName"": ""匹克"",
                ""PlusName"": ""PEAK"",
                ""Country"": ""中国"",
                ""Category"": ""Fashion"",
                ""Grade"": 4,
                ""Tip"": ""口号：I CAN PLAY""
              },
              {
                ""ID"": 192,
                ""Name"": ""奇虎360"",
                ""KeyName"": ""360"",
                ""PlusName"": ""360"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 4,
                ""Tip"": ""创始人周鸿祎，特色产品有：安全卫士和杀毒软件""
              },
              {
                ""ID"": 193,
                ""Name"": ""人人网"",
                ""KeyName"": ""人人"",
                ""PlusName"": ""Renren"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 4,
                ""Tip"": ""中国类似Facebook的实名制社交网络平台""
              },
              {
                ""ID"": 194,
                ""Name"": ""搜狐"",
                ""KeyName"": ""搜狐"",
                ""PlusName"": ""SOHU"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 4,
                ""Tip"": ""中国四大门户网站之一，创始人张朝阳""
              },
              {
                ""ID"": 195,
                ""Name"": ""网易"",
                ""KeyName"": ""网易"",
                ""PlusName"": ""NetEase"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 4,
                ""Tip"": ""中国四大门户网站之一，公司口号：网聚人的力量""
              },
              {
                ""ID"": 196,
                ""Name"": ""微软"",
                ""KeyName"": ""微软"",
                ""PlusName"": ""Microsoft"",
                ""Country"": ""美国"",
                ""Category"": ""Tech"",
                ""Grade"": 4,
                ""Tip"": ""全球最大的电脑软件提供商，著名产品有Windows/Office""
              },
              {
                ""ID"": 197,
                ""Name"": ""高露洁"",
                ""KeyName"": ""高露洁"",
                ""PlusName"": ""Colgate"",
                ""Country"": ""美国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 4,
                ""Tip"": ""销售额达94亿美元的全球消费品公司""
              },
              {
                ""ID"": 198,
                ""Name"": ""西门子"",
                ""KeyName"": ""西门子"",
                ""PlusName"": ""SIEMENS"",
                ""Country"": ""德国"",
                ""Category"": ""Tech"",
                ""Grade"": 4,
                ""Tip"": ""电子电气领头企业，罗永浩砸过其冰箱""
              },
              {
                ""ID"": 199,
                ""Name"": ""华润万家"",
                ""KeyName"": ""华润万家"",
                ""PlusName"": ""Vanguard"",
                ""Country"": ""中国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 4,
                ""Tip"": ""华润旗下的零售连锁企业品牌""
              },
              {
                ""ID"": 200,
                ""Name"": ""小肥羊"",
                ""KeyName"": ""小肥羊"",
                ""PlusName"": ""Little Sheep"",
                ""Country"": ""中国"",
                ""Category"": ""Cater"",
                ""Grade"": 4,
                ""Tip"": ""中国首家在香港上市的品牌餐饮企业，被誉为中华火锅第一股""
              },
              {
                ""ID"": 201,
                ""Name"": ""携程"",
                ""KeyName"": ""携程"",
                ""PlusName"": ""CTRIP"",
                ""Country"": ""中国"",
                ""Category"": ""Walking"",
                ""Grade"": 4,
                ""Tip"": ""在线票务服务公司，标志物为海豚""
              },
              {
                ""ID"": 202,
                ""Name"": ""雪铁龙"",
                ""KeyName"": ""雪铁龙"",
                ""PlusName"": ""Citroen"",
                ""Country"": ""法国"",
                ""Category"": ""Car"",
                ""Grade"": 4,
                ""Tip"": ""与标致同属欧洲第二大汽车制造集团旗下""
              },
              {
                ""ID"": 203,
                ""Name"": ""英菲尼迪"",
                ""KeyName"": ""英菲尼迪"",
                ""PlusName"": ""Infiniti"",
                ""Country"": ""日本"",
                ""Category"": ""Car"",
                ""Grade"": 4,
                ""Tip"": ""日产旗下的豪华车品牌""
              },
              {
                ""ID"": 204,
                ""Name"": ""中兴"",
                ""KeyName"": ""中兴"",
                ""PlusName"": ""ZTE"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 4,
                ""Tip"": ""中国最大的通信设备上市公司""
              },
              {
                ""ID"": 205,
                ""Name"": ""迈凯伦"",
                ""KeyName"": ""迈凯伦"",
                ""PlusName"": ""Mclaren"",
                ""Country"": ""英国"",
                ""Category"": ""Car"",
                ""Grade"": 4,
                ""Tip"": ""超跑品牌，口号：奉献、优质和杰出""
              },
              {
                ""ID"": 206,
                ""Name"": ""菲亚特"",
                ""KeyName"": ""菲亚特"",
                ""PlusName"": ""FIAT"",
                ""Country"": ""意大利"",
                ""Category"": ""Car"",
                ""Grade"": 4,
                ""Tip"": ""世界上第一个微型汽车生产厂家，口号：人生如此美丽""
              },
              {
                ""ID"": 207,
                ""Name"": ""玛莎拉蒂"",
                ""KeyName"": ""玛莎拉蒂"",
                ""PlusName"": ""Maserati"",
                ""Country"": ""意大利"",
                ""Category"": ""Car"",
                ""Grade"": 4,
                ""Tip"": ""口号：发现源自内心的力量，让世界听见你的呐喊""
              },
              {
                ""ID"": 208,
                ""Name"": ""荣威"",
                ""KeyName"": ""荣威"",
                ""PlusName"": ""ROEWE"",
                ""Country"": ""中国"",
                ""Category"": ""Car"",
                ""Grade"": 4,
                ""Tip"": ""上汽集团旗下，口号：品位科技，知你知行""
              },
              {
                ""ID"": 209,
                ""Name"": ""罗孚"",
                ""KeyName"": ""罗孚"",
                ""PlusName"": ""Rover"",
                ""Country"": ""英国"",
                ""Category"": ""Car"",
                ""Grade"": 4,
                ""Tip"": ""其名字寓意为流浪者或领航员""
              },
              {
                ""ID"": 210,
                ""Name"": ""照明娱乐公司"",
                ""KeyName"": ""照明娱乐"",
                ""PlusName"": ""Illumination Entertainment"",
                ""Country"": ""美国"",
                ""Category"": ""AV"",
                ""Grade"": 4,
                ""Tip"": ""环球影业子公司，以卑鄙的我取得成功""
              },
              {
                ""ID"": 211,
                ""Name"": ""工业光魔"",
                ""KeyName"": ""工业光魔"",
                ""PlusName"": ""Industrial Light and Magic"",
                ""Country"": ""美国"",
                ""Category"": ""AV"",
                ""Grade"": 4,
                ""Tip"": ""当今世界电影特效行业顶尖的制作水准""
              },
              {
                ""ID"": 212,
                ""Name"": ""Bad Robot"",
                ""KeyName"": ""Bad Robot"",
                ""PlusName"": ""坏机器人"",
                ""Country"": ""美国"",
                ""Category"": ""AV"",
                ""Grade"": 4,
                ""Tip"": ""JJ艾布拉姆斯持有的美国制片公司""
              },
              {
                ""ID"": 213,
                ""Name"": ""潘婷"",
                ""KeyName"": ""潘婷"",
                ""PlusName"": ""Pantene"",
                ""Country"": ""美国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 4,
                ""Tip"": ""宝洁旗下的修护损伤洗发水品牌，核心成分PRO-V""
              },
              {
                ""ID"": 214,
                ""Name"": ""七匹狼"",
                ""KeyName"": ""七匹狼"",
                ""PlusName"": ""SEPTWOLVES"",
                ""Country"": ""中国"",
                ""Category"": ""Fashion"",
                ""Grade"": 4,
                ""Tip"": ""茄克之王，口号：男人不只一面，品格始终如一""
              },
              {
                ""ID"": 215,
                ""Name"": ""艺龙旅行"",
                ""KeyName"": ""艺龙"",
                ""PlusName"": ""eLong"",
                ""Country"": ""中国"",
                ""Category"": ""Walking"",
                ""Grade"": 4,
                ""Tip"": ""在线旅行服务提供商，logo为一条龙""
              },
              {
                ""ID"": 216,
                ""Name"": ""春秋航空"",
                ""KeyName"": ""春秋"",
                ""PlusName"": ""Spring Airlines"",
                ""Country"": ""中国"",
                ""Category"": ""Walking"",
                ""Grade"": 4,
                ""Tip"": ""首个中国民营资本独资经营的低成本航空公司专线""
              },
              {
                ""ID"": 217,
                ""Name"": ""中国国航"",
                ""KeyName"": ""国航"",
                ""PlusName"": ""AIR CHINA"",
                ""Country"": ""中国"",
                ""Category"": ""Walking"",
                ""Grade"": 4,
                ""Tip"": ""国唯一载国旗飞行的民用航空公司""
              },
              {
                ""ID"": 218,
                ""Name"": ""中国南方航空"",
                ""KeyName"": ""南航"",
                ""PlusName"": ""China Southern Airlines"",
                ""Country"": ""中国"",
                ""Category"": ""Walking"",
                ""Grade"": 4,
                ""Tip"": ""中国运输飞机最多、航线网络最发达、年客运量最大的航空公司""
              },
              {
                ""ID"": 219,
                ""Name"": ""宝丽来"",
                ""KeyName"": ""宝丽来"",
                ""PlusName"": ""Polaroid"",
                ""Country"": ""美国"",
                ""Category"": ""Tech"",
                ""Grade"": 4,
                ""Tip"": ""发明了拍立得照相技术""
              },
              {
                ""ID"": 220,
                ""Name"": ""美国广播公司"",
                ""KeyName"": ""ABC"",
                ""PlusName"": ""ABC"",
                ""Country"": ""美国"",
                ""Category"": ""AV"",
                ""Grade"": 4,
                ""Tip"": ""美国三大商业广播电视公司之一，出品过迷失等经典美剧""
              },
              {
                ""ID"": 221,
                ""Name"": ""HBO"",
                ""KeyName"": ""HBO"",
                ""PlusName"": ""-"",
                ""Country"": ""美国"",
                ""Category"": ""AV"",
                ""Grade"": 4,
                ""Tip"": ""有线电视网络媒体公司，出品过权利的游戏等高口碑剧集""
              },
              {
                ""ID"": 222,
                ""Name"": ""厦门航空"",
                ""KeyName"": ""厦航"",
                ""PlusName"": ""XIAMEN AIRLINES"",
                ""Country"": ""中国"",
                ""Category"": ""Walking"",
                ""Grade"": 4,
                ""Tip"": ""中国唯一使用全波音系列飞机的航空公司""
              },
              {
                ""ID"": 223,
                ""Name"": ""东方航空"",
                ""KeyName"": ""东航"",
                ""PlusName"": ""China Eastern Airlines"",
                ""Country"": ""中国"",
                ""Category"": ""Walking"",
                ""Grade"": 4,
                ""Tip"": ""中国民航第一家在香港、纽约和上海三地上市的航空公司""
              },
              {
                ""ID"": 224,
                ""Name"": ""乐视视频"",
                ""KeyName"": ""乐视"",
                ""PlusName"": ""LETV"",
                ""Country"": ""中国"",
                ""Category"": ""AV"",
                ""Grade"": 4,
                ""Tip"": ""中国A股最早上市的视频公司，创始人：贾跃亭""
              },
              {
                ""ID"": 225,
                ""Name"": ""连我"",
                ""KeyName"": ""LINE"",
                ""PlusName"": ""LINE"",
                ""Country"": ""日本"",
                ""Category"": ""Tech"",
                ""Grade"": 4,
                ""Tip"": ""韩国互联网集团NHN的日本子公司NHN Japan推出的类似微信的社交工具""
              },
              {
                ""ID"": 226,
                ""Name"": ""沃尔玛"",
                ""KeyName"": ""沃尔玛"",
                ""PlusName"": ""Walmart"",
                ""Country"": ""美国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 4,
                ""Tip"": ""世界连锁企业，世界500强企业之首""
              },
              {
                ""ID"": 227,
                ""Name"": ""喜士多"",
                ""KeyName"": ""喜士多"",
                ""PlusName"": ""C-store"",
                ""Country"": ""中国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 4,
                ""Tip"": ""便利店品牌之一，与大润发同属润泰集团""
              },
              {
                ""ID"": 228,
                ""Name"": ""相宜本草"",
                ""KeyName"": ""相宜本草"",
                ""PlusName"": ""INOHERB"",
                ""Country"": ""中国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 4,
                ""Tip"": ""本草养肤领域的领导者，创始人：封帅""
              },
              {
                ""ID"": 229,
                ""Name"": ""中国石油化工集团公司"",
                ""KeyName"": ""中石化"",
                ""PlusName"": ""Sinopec Group"",
                ""Country"": ""中国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 4,
                ""Tip"": ""原中国石油化工总公司基础上重组成立的特大型石油石化企业集团""
              },
              {
                ""ID"": 230,
                ""Name"": ""招商银行"",
                ""KeyName"": ""招行"",
                ""PlusName"": ""China Merchants Bank"",
                ""Country"": ""中国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 4,
                ""Tip"": ""中国第一家完全由企业法人持股的股份制商业银行""
              },
              {
                ""ID"": 231,
                ""Name"": ""欧米茄"",
                ""KeyName"": ""欧米茄"",
                ""PlusName"": ""omega"",
                ""Country"": ""瑞士"",
                ""Category"": ""Fashion"",
                ""Grade"": 4,
                ""Tip"": ""国际著名制表品牌，代表符号Ω""
              },
              {
                ""ID"": 232,
                ""Name"": ""宝骏"",
                ""KeyName"": ""宝骏"",
                ""PlusName"": ""-"",
                ""Country"": ""中国"",
                ""Category"": ""Car"",
                ""Grade"": 4,
                ""Tip"": ""上汽通用五菱2010年创建的自主汽车品牌""
              },
              {
                ""ID"": 233,
                ""Name"": ""长城"",
                ""KeyName"": ""长城"",
                ""PlusName"": ""-"",
                ""Country"": ""中国"",
                ""Category"": ""Car"",
                ""Grade"": 4,
                ""Tip"": ""中国首家在香港H股上市的民营整车汽车企业""
              },
              {
                ""ID"": 234,
                ""Name"": ""85度C"",
                ""KeyName"": ""85°C"",
                ""PlusName"": ""-"",
                ""Country"": ""中国"",
                ""Category"": ""Cater"",
                ""Grade"": 4,
                ""Tip"": ""取名来自咖啡在摄氏85度时喝起来最好喝的意思""
              },
              {
                ""ID"": 235,
                ""Name"": ""去啊"",
                ""KeyName"": ""阿里旅行"",
                ""PlusName"": ""Alitrip"",
                ""Country"": ""中国"",
                ""Category"": ""Walking"",
                ""Grade"": 4,
                ""Tip"": ""淘宝网旗下的综合性旅游出行服务平台""
              },
              {
                ""ID"": 236,
                ""Name"": ""中国国旅"",
                ""KeyName"": ""国旅"",
                ""PlusName"": ""CITS"",
                ""Country"": ""中国"",
                ""Category"": ""Walking"",
                ""Grade"": 4,
                ""Tip"": ""目前国内规模最大、实力最强的旅行社企业集团""
              },
              {
                ""ID"": 237,
                ""Name"": ""红星美凯龙"",
                ""KeyName"": ""红星美凯龙"",
                ""PlusName"": ""Red Star Macalline"",
                ""Country"": ""中国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 4,
                ""Tip"": ""经营面积最大、商场数目最多、地理覆盖面积最广的家居装饰及家具商场运营商""
              },
              {
                ""ID"": 238,
                ""Name"": ""康佳"",
                ""KeyName"": ""康佳"",
                ""PlusName"": ""KONKA"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 4,
                ""Tip"": ""中国改革开放后诞生的第一家中外合资电子企业""
              },
              {
                ""ID"": 239,
                ""Name"": ""中国平安保险"",
                ""KeyName"": ""中国平安"",
                ""PlusName"": ""PING AN INSURANCE"",
                ""Country"": ""中国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 4,
                ""Tip"": ""是中国第一家股份制保险企业""
              },
              {
                ""ID"": 240,
                ""Name"": ""JBL"",
                ""KeyName"": ""JBL"",
                ""PlusName"": ""-"",
                ""Country"": ""美国"",
                ""Category"": ""Tech"",
                ""Grade"": 4,
                ""Tip"": ""全球最大的专业扬声器生产商""
              },
              {
                ""ID"": 241,
                ""Name"": ""罗技"",
                ""KeyName"": ""罗技"",
                ""PlusName"": ""Logitech"",
                ""Country"": ""瑞士"",
                ""Category"": ""Tech"",
                ""Grade"": 4,
                ""Tip"": ""全球著名的电脑周边设备供应商，以鼠标起步的一家瑞士公司""
              },
              {
                ""ID"": 242,
                ""Name"": ""尤尼克斯"",
                ""KeyName"": ""尤尼克斯"",
                ""PlusName"": ""YONEX"",
                ""Country"": ""日本"",
                ""Category"": ""Fashion"",
                ""Grade"": 4,
                ""Tip"": ""羽毛球拍的第一品牌""
              },
              {
                ""ID"": 243,
                ""Name"": ""哈弗"",
                ""KeyName"": ""哈弗"",
                ""PlusName"": ""Haval"",
                ""Country"": ""中国"",
                ""Category"": ""Car"",
                ""Grade"": 4,
                ""Tip"": ""长城汽车旗下品牌""
              },
              {
                ""ID"": 244,
                ""Name"": ""美赞臣"",
                ""KeyName"": ""美赞臣"",
                ""PlusName"": ""Meadjohnson"",
                ""Country"": ""美国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 4,
                ""Tip"": ""婴幼儿营养品品牌，口号：健康机灵，学的更飞凡""
              },
              {
                ""ID"": 245,
                ""Name"": ""H3C"",
                ""KeyName"": ""华三"",
                ""PlusName"": ""杭州华三通信技术有限公司"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 4,
                ""Tip"": ""口号：成为新IT架构领导者""
              },
              {
                ""ID"": 246,
                ""Name"": ""五菱"",
                ""KeyName"": ""五菱"",
                ""PlusName"": ""SGMW"",
                ""Country"": ""中国"",
                ""Category"": ""Car"",
                ""Grade"": 4,
                ""Tip"": ""上汽通用汽车品牌，口号：品质驱动生活""
              },
              {
                ""ID"": 247,
                ""Name"": ""克莱斯勒"",
                ""KeyName"": ""成功"",
                ""PlusName"": ""Chrysler"",
                ""Country"": ""美国"",
                ""Category"": ""Car"",
                ""Grade"": 5,
                ""Tip"": ""美国三大汽车公司之一，香港译为：佳士拿""
              },
              {
                ""ID"": 248,
                ""Name"": ""DS"",
                ""KeyName"": ""美国运通"",
                ""PlusName"": ""-"",
                ""Country"": ""法国"",
                ""Category"": ""Car"",
                ""Grade"": 5,
                ""Tip"": ""法国总统座驾，法国汽车工业顶级设计豪华品牌""
              },
              {
                ""ID"": 249,
                ""Name"": ""Facebook"",
                ""KeyName"": ""加拿大皇家银行"",
                ""PlusName"": ""脸书"",
                ""Country"": ""美国"",
                ""Category"": ""Tech"",
                ""Grade"": 5,
                ""Tip"": ""世界排名第一的照片分享站点""
              },
              {
                ""ID"": 250,
                ""Name"": ""IBM"",
                ""KeyName"": ""渣打银行"",
                ""PlusName"": ""-"",
                ""Country"": ""美国"",
                ""Category"": ""Tech"",
                ""Grade"": 5,
                ""Tip"": ""全球最大的信息技术和业务解决方案公司""
              },
              {
                ""ID"": 251,
                ""Name"": ""MINI"",
                ""KeyName"": ""MINI"",
                ""PlusName"": ""-"",
                ""Country"": ""德国"",
                ""Category"": ""Car"",
                ""Grade"": 5,
                ""Tip"": ""英国BMC汽车公司推出，后属宝马公司""
              },
              {
                ""ID"": 252,
                ""Name"": ""Netflix"",
                ""KeyName"": ""Netflix"",
                ""PlusName"": ""-"",
                ""Country"": ""美国"",
                ""Category"": ""AV"",
                ""Grade"": 5,
                ""Tip"": ""世界最大的在线影片租赁服务商""
              },
              {
                ""ID"": 253,
                ""Name"": ""TNT快递"",
                ""KeyName"": ""TNT"",
                ""PlusName"": ""TNT"",
                ""Country"": ""荷兰"",
                ""Category"": ""Walking"",
                ""Grade"": 5,
                ""Tip"": ""总部位于荷兰的全球最大的快递公司之一""
              },
              {
                ""ID"": 254,
                ""Name"": ""Twitter"",
                ""KeyName"": ""Twitter"",
                ""PlusName"": ""推特"",
                ""Country"": ""美国"",
                ""Category"": ""Tech"",
                ""Grade"": 5,
                ""Tip"": ""美国社交及微博客服务的网站，每条消息不超过140个字""
              },
              {
                ""ID"": 255,
                ""Name"": ""艾德熊"",
                ""KeyName"": ""艾德熊"",
                ""PlusName"": ""A\u0026W"",
                ""Country"": ""美国"",
                ""Category"": ""Cater"",
                ""Grade"": 5,
                ""Tip"": ""创造出了乐啤露，极富天然成分的饮料""
              },
              {
                ""ID"": 256,
                ""Name"": ""爱国者"",
                ""KeyName"": ""爱国者"",
                ""PlusName"": ""aigo"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 5,
                ""Tip"": ""华旗资讯旗下数码品牌""
              },
              {
                ""ID"": 257,
                ""Name"": ""奥林巴斯"",
                ""KeyName"": ""奥林巴斯"",
                ""PlusName"": ""Olympus"",
                ""Country"": ""日本"",
                ""Category"": ""Tech"",
                ""Grade"": 5,
                ""Tip"": ""在日本第一次成功地将显微镜商品化""
              },
              {
                ""ID"": 258,
                ""Name"": ""百胜"",
                ""KeyName"": ""百胜"",
                ""PlusName"": ""Tricon"",
                ""Country"": ""美国"",
                ""Category"": ""Cater"",
                ""Grade"": 5,
                ""Tip"": ""全球最大的餐饮集团""
              },
              {
                ""ID"": 259,
                ""Name"": ""别克"",
                ""KeyName"": ""别克"",
                ""PlusName"": ""Buick"",
                ""Country"": ""美国"",
                ""Category"": ""Car"",
                ""Grade"": 5,
                ""Tip"": ""通用旗下汽车品牌，商标为著名的三盾标志""
              },
              {
                ""ID"": 260,
                ""Name"": ""达美乐"",
                ""KeyName"": ""达美乐"",
                ""PlusName"": ""Domino"",
                ""Country"": ""美国"",
                ""Category"": ""Cater"",
                ""Grade"": 5,
                ""Tip"": ""世界三大披萨品牌之一""
              },
              {
                ""ID"": 261,
                ""Name"": ""底特律电动车"",
                ""KeyName"": ""底特律"",
                ""PlusName"": ""DETROIT ELECTRIC"",
                ""Country"": ""荷兰"",
                ""Category"": ""Car"",
                ""Grade"": 5,
                ""Tip"": ""前身为安德森电动汽车公司""
              },
              {
                ""ID"": 262,
                ""Name"": ""哥伦比亚影业公司"",
                ""KeyName"": ""哥伦比亚"",
                ""PlusName"": ""Columbia"",
                ""Country"": ""美国"",
                ""Category"": ""AV"",
                ""Grade"": 5,
                ""Tip"": ""好莱坞八大电影公司之一，目前属索尼旗下""
              },
              {
                ""ID"": 263,
                ""Name"": ""海思半导体"",
                ""KeyName"": ""海思"",
                ""PlusName"": ""Hisilicon"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 5,
                ""Tip"": ""前身是华为集成电路设计中心""
              },
              {
                ""ID"": 264,
                ""Name"": ""环球影业"",
                ""KeyName"": ""环球"",
                ""PlusName"": ""Universal Picture"",
                ""Country"": ""美国"",
                ""Category"": ""AV"",
                ""Grade"": 5,
                ""Tip"": ""好莱坞八大电影公司之一，曾出品过侏罗纪公园""
              },
              {
                ""ID"": 265,
                ""Name"": ""技嘉"",
                ""KeyName"": ""技嘉"",
                ""PlusName"": ""GIGABYTE"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 5,
                ""Tip"": ""台湾第二大专业主板制造商""
              },
              {
                ""ID"": 266,
                ""Name"": ""卡西欧"",
                ""KeyName"": ""卡西欧"",
                ""PlusName"": ""CASIO"",
                ""Country"": ""日本"",
                ""Category"": ""Tech"",
                ""Grade"": 5,
                ""Tip"": ""生产电子仪器、电子计算器为主，在中国以其计算器、手表闻名""
              },
              {
                ""ID"": 267,
                ""Name"": ""凯迪拉克"",
                ""KeyName"": ""凯迪拉克"",
                ""PlusName"": ""Cadillac"",
                ""Country"": ""美国"",
                ""Category"": ""Car"",
                ""Grade"": 5,
                ""Tip"": ""通用集团旗下一款豪华汽车品牌，标志为冠+盾""
              },
              {
                ""ID"": 268,
                ""Name"": ""莱卡"",
                ""KeyName"": ""莱卡"",
                ""PlusName"": ""leica"",
                ""Country"": ""德国"",
                ""Category"": ""Tech"",
                ""Grade"": 5,
                ""Tip"": ""产于德国的精良世界级相机品牌""
              },
              {
                ""ID"": 269,
                ""Name"": ""兰博基尼"",
                ""KeyName"": ""兰博基尼"",
                ""PlusName"": ""Lamborghini"",
                ""Country"": ""意大利"",
                ""Category"": ""Car"",
                ""Grade"": 5,
                ""Tip"": ""全球顶级跑车制造商，其标志是一头充满力量、正向对方攻击的斗牛""
              },
              {
                ""ID"": 270,
                ""Name"": ""朗世"",
                ""KeyName"": ""朗世"",
                ""PlusName"": ""RANZ"",
                ""Country"": ""中国"",
                ""Category"": ""Car"",
                ""Grade"": 5,
                ""Tip"": ""一汽丰田全新合资自主品牌，主要开发纯电动汽车""
              },
              {
                ""ID"": 271,
                ""Name"": ""雷诺"",
                ""KeyName"": ""雷诺"",
                ""PlusName"": ""Renault"",
                ""Country"": ""法国"",
                ""Category"": ""Car"",
                ""Grade"": 5,
                ""Tip"": ""口号：Drive the Change""
              },
              {
                ""ID"": 272,
                ""Name"": ""明基"",
                ""KeyName"": ""明基"",
                ""PlusName"": ""BenQ"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 5,
                ""Tip"": ""创始人同宏碁：施振荣""
              },
              {
                ""ID"": 273,
                ""Name"": ""欧宝"",
                ""KeyName"": ""欧宝"",
                ""PlusName"": ""OPEL"",
                ""Country"": ""德国"",
                ""Category"": ""Car"",
                ""Grade"": 5,
                ""Tip"": ""通用汽车子公司，由Adam Opel创立""
              },
              {
                ""ID"": 274,
                ""Name"": ""乔丹"",
                ""KeyName"": ""乔丹"",
                ""PlusName"": ""QIAODAN"",
                ""Country"": ""中国"",
                ""Category"": ""Fashion"",
                ""Grade"": 5,
                ""Tip"": ""口号：跨越.新生""
              },
              {
                ""ID"": 275,
                ""Name"": ""乔治·巴顿"",
                ""KeyName"": ""乔治巴顿"",
                ""PlusName"": ""G.PATTON"",
                ""Country"": ""美国"",
                ""Category"": ""Car"",
                ""Grade"": 5,
                ""Tip"": ""美国产超级越野车，以二战时期同名美国将领命名""
              },
              {
                ""ID"": 276,
                ""Name"": ""21世纪不动产"",
                ""KeyName"": ""21世纪不动产"",
                ""PlusName"": ""CENTURY 21"",
                ""Country"": ""美国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 5,
                ""Tip"": ""全球最大的房地产综合服务提供商""
              },
              {
                ""ID"": 277,
                ""Name"": ""日产"",
                ""KeyName"": ""日产"",
                ""PlusName"": ""NISSAN"",
                ""Country"": ""日本"",
                ""Category"": ""Car"",
                ""Grade"": 5,
                ""Tip"": ""日本第二大汽车制造商""
              },
              {
                ""ID"": 278,
                ""Name"": ""ebay"",
                ""KeyName"": ""ebay"",
                ""PlusName"": ""-"",
                ""Country"": ""美国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 5,
                ""Tip"": ""全球最大的国际贸易电子商务平台""
              },
              {
                ""ID"": 279,
                ""Name"": ""锐步"",
                ""KeyName"": ""锐步"",
                ""PlusName"": ""Reebok"",
                ""Country"": ""美国"",
                ""Category"": ""Fashion"",
                ""Grade"": 5,
                ""Tip"": ""美国运动品牌Reebok，后被阿迪达斯收购""
              },
              {
                ""ID"": 280,
                ""Name"": ""赛百味"",
                ""KeyName"": ""赛百味"",
                ""PlusName"": ""Subway"",
                ""Country"": ""美国"",
                ""Category"": ""Cater"",
                ""Grade"": 5,
                ""Tip"": ""世界上扩张最快及最大单一品牌连锁店，主要贩售三明治和沙拉""
              },
              {
                ""ID"": 281,
                ""Name"": ""双龙"",
                ""KeyName"": ""双龙"",
                ""PlusName"": ""SSANG YONG"",
                ""Country"": ""韩国"",
                ""Category"": ""Car"",
                ""Grade"": 5,
                ""Tip"": ""前身为韩国东亚汽车公司""
              },
              {
                ""ID"": 282,
                ""Name"": ""思科"",
                ""KeyName"": ""思科"",
                ""PlusName"": ""Cisco"",
                ""Country"": ""美国"",
                ""Category"": ""Tech"",
                ""Grade"": 5,
                ""Tip"": ""全球领先的互联网解决方案供应商，名字取自San Francisco""
              },
              {
                ""ID"": 283,
                ""Name"": ""索尼"",
                ""KeyName"": ""索尼"",
                ""PlusName"": ""Sony"",
                ""Country"": ""日本"",
                ""Category"": ""Tech"",
                ""Grade"": 5,
                ""Tip"": ""世界最早便携式数码产品的开创者""
              },
              {
                ""ID"": 284,
                ""Name"": ""特斯拉"",
                ""KeyName"": ""特斯拉"",
                ""PlusName"": ""Tesla"",
                ""Country"": ""美国"",
                ""Category"": ""Car"",
                ""Grade"": 5,
                ""Tip"": ""最著名的高性能纯电动汽车品牌""
              },
              {
                ""ID"": 285,
                ""Name"": ""唯品会"",
                ""KeyName"": ""唯品会"",
                ""PlusName"": ""Vipshop"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 5,
                ""Tip"": ""一家专门做特卖的网站""
              },
              {
                ""ID"": 286,
                ""Name"": ""宝洁"",
                ""KeyName"": ""宝洁"",
                ""PlusName"": ""P\u0026G"",
                ""Country"": ""美国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 5,
                ""Tip"": ""全球最大的日用消费品公司""
              },
              {
                ""ID"": 287,
                ""Name"": ""现代"",
                ""KeyName"": ""现代"",
                ""PlusName"": ""HYUNDAI"",
                ""Country"": ""韩国"",
                ""Category"": ""Car"",
                ""Grade"": 5,
                ""Tip"": ""韩国汽车品牌，主要生产suv及普通家用轿车""
              },
              {
                ""ID"": 288,
                ""Name"": ""家乐福"",
                ""KeyName"": ""家乐福"",
                ""PlusName"": ""Carrefour"",
                ""Country"": ""法国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 5,
                ""Tip"": ""欧洲第一大零售商""
              },
              {
                ""ID"": 289,
                ""Name"": ""许留山"",
                ""KeyName"": ""许留山"",
                ""PlusName"": ""HuiLauShan"",
                ""Country"": ""中国"",
                ""Category"": ""Cater"",
                ""Grade"": 5,
                ""Tip"": ""香港著名连锁式甜品店，以芒果为主要材料""
              },
              {
                ""ID"": 290,
                ""Name"": ""英特尔"",
                ""KeyName"": ""英特尔"",
                ""PlusName"": ""Intel"",
                ""Country"": ""美国"",
                ""Category"": ""Tech"",
                ""Grade"": 5,
                ""Tip"": ""全球最大的个人计算机零件和CPU制造商""
              },
              {
                ""ID"": 291,
                ""Name"": ""英伟达"",
                ""KeyName"": ""英伟达"",
                ""PlusName"": ""NVIDA"",
                ""Country"": ""美国"",
                ""Category"": ""Tech"",
                ""Grade"": 5,
                ""Tip"": ""全球著名IC半导体公司，其显卡俗称N卡""
              },
              {
                ""ID"": 292,
                ""Name"": ""乐购"",
                ""KeyName"": ""乐购"",
                ""PlusName"": ""TESCO"",
                ""Country"": ""英国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 5,
                ""Tip"": ""英国最大的零售公司，世界三大零售商之一""
              },
              {
                ""ID"": 293,
                ""Name"": ""优速快递"",
                ""KeyName"": ""优速"",
                ""PlusName"": ""-"",
                ""Country"": ""中国"",
                ""Category"": ""Walking"",
                ""Grade"": 5,
                ""Tip"": ""口号：一路呵护所托""
              },
              {
                ""ID"": 294,
                ""Name"": ""优衣库"",
                ""KeyName"": ""优衣库"",
                ""PlusName"": ""UNIQLO"",
                ""Country"": ""日本"",
                ""Category"": ""Fashion"",
                ""Grade"": 5,
                ""Tip"": ""日本国际知名服装品牌，曾出过xxx试衣间热点新闻""
              },
              {
                ""ID"": 295,
                ""Name"": ""友讯集团"",
                ""KeyName"": ""友讯"",
                ""PlusName"": ""D-Link"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 5,
                ""Tip"": ""口号：Building Networks for People""
              },
              {
                ""ID"": 296,
                ""Name"": ""宅急送"",
                ""KeyName"": ""宅急送"",
                ""PlusName"": ""-"",
                ""Country"": ""中国"",
                ""Category"": ""Walking"",
                ""Grade"": 5,
                ""Tip"": ""口号：安全、准确、亲切、视服务为生命""
              },
              {
                ""ID"": 297,
                ""Name"": ""新线"",
                ""KeyName"": ""新线"",
                ""PlusName"": ""New Line cinema"",
                ""Country"": ""美国"",
                ""Category"": ""AV"",
                ""Grade"": 5,
                ""Tip"": ""发行过指环王系列电影""
              },
              {
                ""ID"": 298,
                ""Name"": ""湖岸影业"",
                ""KeyName"": ""湖岸"",
                ""PlusName"": ""Lakeshore Entertainment"",
                ""Country"": ""美国"",
                ""Category"": ""AV"",
                ""Grade"": 5,
                ""Tip"": ""出品过黑夜传说系列电影""
              },
              {
                ""ID"": 299,
                ""Name"": ""施华洛世奇"",
                ""KeyName"": ""洛世奇"",
                ""PlusName"": ""SWAROVSKI"",
                ""Country"": ""奥地利"",
                ""Category"": ""Fashion"",
                ""Grade"": 5,
                ""Tip"": ""全球首屈一指的精确切割仿水晶制造商""
              },
              {
                ""ID"": 300,
                ""Name"": ""柯达"",
                ""KeyName"": ""柯达"",
                ""PlusName"": ""Kodak"",
                ""Country"": ""美国"",
                ""Category"": ""Tech"",
                ""Grade"": 5,
                ""Tip"": ""影像品牌，创始人：乔治伊士曼""
              },
              {
                ""ID"": 301,
                ""Name"": ""博世"",
                ""KeyName"": ""博世"",
                ""PlusName"": ""BOSCH"",
                ""Country"": ""德国"",
                ""Category"": ""Tech"",
                ""Grade"": 5,
                ""Tip"": ""德国工业企业，全球第一大汽车技术供应商""
              },
              {
                ""ID"": 302,
                ""Name"": ""柒牌"",
                ""KeyName"": ""柒牌"",
                ""PlusName"": ""SEVEN"",
                ""Country"": ""中国"",
                ""Category"": ""Fashion"",
                ""Grade"": 5,
                ""Tip"": ""民营服装品牌，发音同seven/7""
              },
              {
                ""ID"": 303,
                ""Name"": ""俏江南"",
                ""KeyName"": ""俏江南"",
                ""PlusName"": ""South Beauty"",
                ""Country"": ""中国"",
                ""Category"": ""Cater"",
                ""Grade"": 5,
                ""Tip"": ""口号：要做中餐中的LV，创始人：张兰""
              },
              {
                ""ID"": 304,
                ""Name"": ""全家"",
                ""KeyName"": ""全家"",
                ""PlusName"": ""FamilyMart"",
                ""Country"": ""日本"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 5,
                ""Tip"": ""第一家由亚洲发起进入美国市场的便利店企业""
              },
              {
                ""ID"": 305,
                ""Name"": ""西雅衣家"",
                ""KeyName"": ""c\u0026a"",
                ""PlusName"": ""c\u0026a"",
                ""Country"": ""荷兰"",
                ""Category"": ""Fashion"",
                ""Grade"": 5,
                ""Tip"": ""世界领先的时装零售商，旗下有Clockhouse等品牌""
              },
              {
                ""ID"": 306,
                ""Name"": ""美国全国广播公司"",
                ""KeyName"": ""NBC"",
                ""PlusName"": ""NBC"",
                ""Country"": ""美国"",
                ""Category"": ""AV"",
                ""Grade"": 5,
                ""Tip"": ""美国历史最久、实力最强的商业广播电视公司""
              },
              {
                ""ID"": 307,
                ""Name"": ""哥伦比亚广播公司"",
                ""KeyName"": ""CBS"",
                ""PlusName"": ""CBS"",
                ""Country"": ""美国"",
                ""Category"": ""AV"",
                ""Grade"": 5,
                ""Tip"": ""美国三大商业广播电视公司之一，出品过生活大爆炸等经典美剧""
              },
              {
                ""ID"": 308,
                ""Name"": ""Vimeo"",
                ""KeyName"": ""Vimeo"",
                ""PlusName"": ""-"",
                ""Country"": ""美国"",
                ""Category"": ""AV"",
                ""Grade"": 5,
                ""Tip"": ""高清视频播客网站，允许每月上传500MB的视频""
              },
              {
                ""ID"": 309,
                ""Name"": ""如家"",
                ""KeyName"": ""如家"",
                ""PlusName"": ""Home Inn"",
                ""Country"": ""中国"",
                ""Category"": ""Walking"",
                ""Grade"": 5,
                ""Tip"": ""品牌价值居中国酒店行业之首""
              },
              {
                ""ID"": 310,
                ""Name"": ""味全"",
                ""KeyName"": ""味全"",
                ""PlusName"": ""wei-chuan"",
                ""Country"": ""中国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 5,
                ""Tip"": ""台湾知名综合食品企业，现属顶新集团""
              },
              {
                ""ID"": 311,
                ""Name"": ""新蛋网"",
                ""KeyName"": ""新蛋"",
                ""PlusName"": ""Newegg"",
                ""Country"": ""美国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 5,
                ""Tip"": ""全美规模最大的IT数码类网上零售商""
              },
              {
                ""ID"": 312,
                ""Name"": ""永辉超市"",
                ""KeyName"": ""永辉超市"",
                ""PlusName"": ""YONGHUI"",
                ""Country"": ""中国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 5,
                ""Tip"": ""中国十强连锁超市，创始人张轩松""
              },
              {
                ""ID"": 313,
                ""Name"": ""花王"",
                ""KeyName"": ""花王"",
                ""PlusName"": ""kao"",
                ""Country"": ""日本"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 5,
                ""Tip"": ""日本知名日用品品牌，创始人：长濑富郎""
              },
              {
                ""ID"": 314,
                ""Name"": ""中国大唐集团公司"",
                ""KeyName"": ""大唐"",
                ""PlusName"": ""CHINA DATANG CORPORATION"",
                ""Country"": ""中国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 5,
                ""Tip"": ""原国家电力公司部分企事业单位基础上组建而成的特大型发电企业集团""
              },
              {
                ""ID"": 315,
                ""Name"": ""浦发银行"",
                ""KeyName"": ""浦发"",
                ""PlusName"": ""spdb"",
                ""Country"": ""中国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 5,
                ""Tip"": ""总部位于上海的商业银行，口号：笃守诚信、创造卓越""
              },
              {
                ""ID"": 316,
                ""Name"": ""costa咖啡"",
                ""KeyName"": ""costa"",
                ""PlusName"": ""咖世家"",
                ""Country"": ""英国"",
                ""Category"": ""Cater"",
                ""Grade"": 5,
                ""Tip"": ""英国连锁咖啡店第一品牌""
              },
              {
                ""ID"": 317,
                ""Name"": ""迪奥"",
                ""KeyName"": ""迪奥"",
                ""PlusName"": ""Dior"",
                ""Country"": ""法国"",
                ""Category"": ""Fashion"",
                ""Grade"": 5,
                ""Tip"": ""LVMH旗下品牌，在法文中是上帝(Dieu)和金子(or)的组合""
              },
              {
                ""ID"": 318,
                ""Name"": ""永和大王"",
                ""KeyName"": ""永和大王"",
                ""PlusName"": ""-"",
                ""Country"": ""中国"",
                ""Category"": ""Cater"",
                ""Grade"": 5,
                ""Tip"": ""全国连锁快餐企业，经营符合中国人口味的豆浆、油条、稀饭和中式小点心""
              },
              {
                ""ID"": 319,
                ""Name"": ""永和豆浆"",
                ""KeyName"": ""永和豆浆"",
                ""PlusName"": ""Yonghe soybean milk"",
                ""Country"": ""中国"",
                ""Category"": ""Cater"",
                ""Grade"": 5,
                ""Tip"": ""台湾弘奇食品有限公司创立餐饮业知名品牌""
              },
              {
                ""ID"": 320,
                ""Name"": ""农夫山泉"",
                ""KeyName"": ""农夫山泉"",
                ""PlusName"": ""NONGFU SPRING"",
                ""Country"": ""中国"",
                ""Category"": ""Cater"",
                ""Grade"": 5,
                ""Tip"": ""口号：我们是大自然的搬运工""
              },
              {
                ""ID"": 321,
                ""Name"": ""太平洋咖啡"",
                ""KeyName"": ""太平洋咖啡"",
                ""PlusName"": ""Pacific Coffee"",
                ""Country"": ""中国"",
                ""Category"": ""Cater"",
                ""Grade"": 5,
                ""Tip"": ""华润旗下唯一的咖啡连锁品牌""
              },
              {
                ""ID"": 322,
                ""Name"": ""途牛旅游"",
                ""KeyName"": ""途牛"",
                ""PlusName"": ""Tuniu"",
                ""Country"": ""中国"",
                ""Category"": ""Walking"",
                ""Grade"": 5,
                ""Tip"": ""口号：阳光价格、阳光行程、阳光支持""
              },
              {
                ""ID"": 323,
                ""Name"": ""魔声"",
                ""KeyName"": ""魔声"",
                ""PlusName"": ""monster"",
                ""Country"": ""美国"",
                ""Category"": ""Tech"",
                ""Grade"": 5,
                ""Tip"": ""创始人：李美圣，全球领先的高品质耳机制造商""
              },
              {
                ""ID"": 324,
                ""Name"": ""观致"",
                ""KeyName"": ""观致"",
                ""PlusName"": ""QOROS"",
                ""Country"": ""中国"",
                ""Category"": ""Car"",
                ""Grade"": 5,
                ""Tip"": ""从零开始的中国汽车公司，口号：创造未来的历史""
              },
              {
                ""ID"": 325,
                ""Name"": ""爱登堡"",
                ""KeyName"": ""爱登堡"",
                ""PlusName"": ""Edenbo"",
                ""Country"": ""中国"",
                ""Category"": ""Fashion"",
                ""Grade"": 5,
                ""Tip"": ""以英伦文化及派克文化为背景的著名休闲服饰品牌""
              },
              {
                ""ID"": 326,
                ""Name"": ""麦斯威尔"",
                ""KeyName"": ""麦斯威尔"",
                ""PlusName"": ""Maxwell"",
                ""Country"": ""美国"",
                ""Category"": ""Cater"",
                ""Grade"": 5,
                ""Tip"": ""享誉全球的百年咖啡品，宣传语：滴滴香浓，意犹未尽""
              },
              {
                ""ID"": 327,
                ""Name"": ""花旗银行"",
                ""KeyName"": ""花旗"",
                ""PlusName"": ""Citibank"",
                ""Country"": ""美国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 5,
                ""Tip"": ""美国最大的银行之一，前身是纽约城市银行""
              },
              {
                ""ID"": 328,
                ""Name"": ""fitbit"",
                ""KeyName"": ""fitbit"",
                ""PlusName"": ""-"",
                ""Country"": ""美国"",
                ""Category"": ""Tech"",
                ""Grade"": 5,
                ""Tip"": ""第一家上市的可穿戴设备公司，全球份额第一""
              },
              {
                ""ID"": 329,
                ""Name"": ""富士康"",
                ""KeyName"": ""富士康"",
                ""PlusName"": ""Foxconn"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 5,
                ""Tip"": ""台湾鸿海精密集团的高新科技企业，创立人：郭台铭""
              },
              {
                ""ID"": 330,
                ""Name"": ""卡尔森"",
                ""KeyName"": ""卡尔森"",
                ""PlusName"": ""Carlsson"",
                ""Country"": ""德国"",
                ""Category"": ""Car"",
                ""Grade"": 6,
                ""Tip"": ""名字源自瑞典著名赛车手Ingvar Carlsson""
              },
              {
                ""ID"": 331,
                ""Name"": ""Smart"",
                ""KeyName"": ""Smart"",
                ""PlusName"": ""-"",
                ""Country"": ""德国"",
                ""Category"": ""Car"",
                ""Grade"": 6,
                ""Tip"": ""梅赛德斯-奔驰与手表巨头瑞士Swatch公司合作的产物""
              },
              {
                ""ID"": 332,
                ""Name"": ""宝沃"",
                ""KeyName"": ""宝沃"",
                ""PlusName"": ""BORGWARD"",
                ""Country"": ""德国"",
                ""Category"": ""Car"",
                ""Grade"": 6,
                ""Tip"": ""诞生于德国不莱梅，其logo寓意：城堡守护者""
              },
              {
                ""ID"": 333,
                ""Name"": ""沃尔沃"",
                ""KeyName"": ""沃尔沃"",
                ""PlusName"": ""Volvo"",
                ""Country"": ""瑞典"",
                ""Category"": ""Car"",
                ""Grade"": 6,
                ""Tip"": ""瑞典豪车品牌，口号：矢志以人为尊""
              },
              {
                ""ID"": 334,
                ""Name"": ""forever 21"",
                ""KeyName"": ""forever 21"",
                ""PlusName"": ""-"",
                ""Country"": ""美国"",
                ""Category"": ""Fashion"",
                ""Grade"": 6,
                ""Tip"": ""最受美国年轻人欢迎的大众时尚品牌""
              },
              {
                ""ID"": 335,
                ""Name"": ""GoPro"",
                ""KeyName"": ""GoPro"",
                ""PlusName"": ""-"",
                ""Country"": ""美国"",
                ""Category"": ""Tech"",
                ""Grade"": 6,
                ""Tip"": ""极限运动专用相机的代名词""
              },
              {
                ""ID"": 336,
                ""Name"": ""Hulu"",
                ""KeyName"": ""Hulu"",
                ""PlusName"": ""-"",
                ""Country"": ""美国"",
                ""Category"": ""AV"",
                ""Grade"": 6,
                ""Tip"": ""由美国NBC和FOX共同成立的一家视频分享网站""
              },
              {
                ""ID"": 337,
                ""Name"": ""Paypal"",
                ""KeyName"": ""Paypal"",
                ""PlusName"": ""贝宝"",
                ""Country"": ""美国"",
                ""Category"": ""Tech"",
                ""Grade"": 6,
                ""Tip"": ""国际贸易支付工具，创始人：埃隆·马斯克""
              },
              {
                ""ID"": 338,
                ""Name"": ""阿玛尼"",
                ""KeyName"": ""阿玛尼"",
                ""PlusName"": ""Armani"",
                ""Country"": ""意大利"",
                ""Category"": ""Fashion"",
                ""Grade"": 6,
                ""Tip"": ""美国销量最大的欧洲设计师品牌""
              },
              {
                ""ID"": 339,
                ""Name"": ""爱普生"",
                ""KeyName"": ""爱普生"",
                ""PlusName"": ""Epson"",
                ""Country"": ""日本"",
                ""Category"": ""Tech"",
                ""Grade"": 6,
                ""Tip"": ""口号：Exceed Your Vision""
              },
              {
                ""ID"": 340,
                ""Name"": ""棒约翰"",
                ""KeyName"": ""棒约翰"",
                ""PlusName"": ""Papa Johns"",
                ""Country"": ""美国"",
                ""Category"": ""Cater"",
                ""Grade"": 6,
                ""Tip"": ""世界三大披萨品牌之一：Better Ingredients，Better pizza！""
              },
              {
                ""ID"": 341,
                ""Name"": ""冰雪皇后"",
                ""KeyName"": ""冰雪皇后"",
                ""PlusName"": ""Dairy Queen"",
                ""Country"": ""美国"",
                ""Category"": ""Cater"",
                ""Grade"": 6,
                ""Tip"": ""世界最大软冰淇淋销售商""
              },
              {
                ""ID"": 342,
                ""Name"": ""达美航空"",
                ""KeyName"": ""达美"",
                ""PlusName"": ""Delta Air Lines"",
                ""Country"": ""美国"",
                ""Category"": ""Walking"",
                ""Grade"": 6,
                ""Tip"": ""隶属于天合联盟，美国第三大航空公司""
              },
              {
                ""ID"": 343,
                ""Name"": ""达能"",
                ""KeyName"": ""达能"",
                ""PlusName"": ""Danone"",
                ""Country"": ""法国"",
                ""Category"": ""Cater"",
                ""Grade"": 6,
                ""Tip"": ""欧洲第三大食品集团""
              },
              {
                ""ID"": 344,
                ""Name"": ""大华"",
                ""KeyName"": ""大华"",
                ""PlusName"": ""dahua"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 6,
                ""Tip"": ""中国安防第二品牌""
              },
              {
                ""ID"": 345,
                ""Name"": ""道奇"",
                ""KeyName"": ""道奇"",
                ""PlusName"": ""Dodge"",
                ""Country"": ""美国"",
                ""Category"": ""Car"",
                ""Grade"": 6,
                ""Tip"": ""名称采用创始人两兄弟的姓氏，图形商标是五边形中有一羊头的形象""
              },
              {
                ""ID"": 346,
                ""Name"": ""德州仪器"",
                ""KeyName"": ""德州仪器"",
                ""PlusName"": ""TI"",
                ""Country"": ""美国"",
                ""Category"": ""Tech"",
                ""Grade"": 6,
                ""Tip"": ""世界上最大的模拟电路技术部件制造商""
              },
              {
                ""ID"": 347,
                ""Name"": ""杜嘉班纳"",
                ""KeyName"": ""杜嘉班纳"",
                ""PlusName"": ""DOLCE\u0026GABBANA"",
                ""Country"": ""意大利"",
                ""Category"": ""Fashion"",
                ""Grade"": 6,
                ""Tip"": ""意大利一线奢侈品牌，D\u0026G""
              },
              {
                ""ID"": 348,
                ""Name"": ""二十世纪福克斯"",
                ""KeyName"": ""二十世纪福克斯"",
                ""PlusName"": ""20th Century Fox"",
                ""Country"": ""美国"",
                ""Category"": ""AV"",
                ""Grade"": 6,
                ""Tip"": ""好莱坞八大电影公司之一，发行过星球大战""
              },
              {
                ""ID"": 349,
                ""Name"": ""飞思卡尔"",
                ""KeyName"": ""飞思卡尔"",
                ""PlusName"": ""Freescale"",
                ""Country"": ""美国"",
                ""Category"": ""Tech"",
                ""Grade"": 6,
                ""Tip"": ""全球领先的半导体公司，赞助举办有以其品牌命名的全国大学生智能车竞赛""
              },
              {
                ""ID"": 350,
                ""Name"": ""高通"",
                ""KeyName"": ""高通"",
                ""PlusName"": ""Qualcomm"",
                ""Country"": ""美国"",
                ""Category"": ""Tech"",
                ""Grade"": 6,
                ""Tip"": ""无线电通信技术研发公司，目前使用最多的智能手机处理器厂商""
              },
              {
                ""ID"": 351,
                ""Name"": ""海康威视"",
                ""KeyName"": ""海康威视"",
                ""PlusName"": ""HIKVISION"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 6,
                ""Tip"": ""中国/全球安防第一品牌""
              },
              {
                ""ID"": 352,
                ""Name"": ""汉堡王"",
                ""KeyName"": ""汉堡王"",
                ""PlusName"": ""Burger King"",
                ""Country"": ""美国"",
                ""Category"": ""Cater"",
                ""Grade"": 6,
                ""Tip"": ""全球第二大快餐连锁企业""
              },
              {
                ""ID"": 353,
                ""Name"": ""华纳兄弟"",
                ""KeyName"": ""华纳"",
                ""PlusName"": ""Warner Bros"",
                ""Country"": ""美国"",
                ""Category"": ""AV"",
                ""Grade"": 6,
                ""Tip"": ""好莱坞八大电影公司之一，创造了007经典影视形象""
              },
              {
                ""ID"": 354,
                ""Name"": ""金士顿"",
                ""KeyName"": ""金士顿"",
                ""PlusName"": ""kingston"",
                ""Country"": ""美国"",
                ""Category"": ""Tech"",
                ""Grade"": 6,
                ""Tip"": ""全球最大的独立内存产品制造商""
              },
              {
                ""ID"": 355,
                ""Name"": ""卡夫"",
                ""KeyName"": ""卡夫"",
                ""PlusName"": ""Kraft"",
                ""Country"": ""美国"",
                ""Category"": ""Cater"",
                ""Grade"": 6,
                ""Tip"": ""全球第二大食品公司""
              },
              {
                ""ID"": 356,
                ""Name"": ""跨越速运"",
                ""KeyName"": ""跨越"",
                ""PlusName"": ""KYE"",
                ""Country"": ""中国"",
                ""Category"": ""Walking"",
                ""Grade"": 6,
                ""Tip"": ""口号：创快递先锋、建百年xx""
              },
              {
                ""ID"": 357,
                ""Name"": ""劳力士"",
                ""KeyName"": ""劳力士"",
                ""PlusName"": ""Rolex"",
                ""Country"": ""瑞士"",
                ""Category"": ""Fashion"",
                ""Grade"": 6,
                ""Tip"": ""世界十大名表之一，在中国一枝独秀，曾译罗莱克斯""
              },
              {
                ""ID"": 358,
                ""Name"": ""劳斯莱斯"",
                ""KeyName"": ""劳斯莱斯"",
                ""PlusName"": ""Rolls-Royce"",
                ""Country"": ""英国"",
                ""Category"": ""Car"",
                ""Grade"": 6,
                ""Tip"": ""世界顶级超豪华轿车厂商""
              },
              {
                ""ID"": 359,
                ""Name"": ""联发科"",
                ""KeyName"": ""联发科"",
                ""PlusName"": ""MediaTek"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 6,
                ""Tip"": ""全球著名IC设计厂商，简称MTK""
              },
              {
                ""ID"": 360,
                ""Name"": ""铃木"",
                ""KeyName"": ""铃木"",
                ""PlusName"": ""SUZUKI"",
                ""Country"": ""日本"",
                ""Category"": ""Car"",
                ""Grade"": 6,
                ""Tip"": ""日本第四大汽车制造商，通用持有其10%的股权""
              },
              {
                ""ID"": 361,
                ""Name"": ""领英"",
                ""KeyName"": ""领英"",
                ""PlusName"": ""LinkedIn"",
                ""Country"": ""美国"",
                ""Category"": ""Tech"",
                ""Grade"": 6,
                ""Tip"": ""全球最大的职业社交网站""
              },
              {
                ""ID"": 362,
                ""Name"": ""派拉蒙"",
                ""KeyName"": ""派拉蒙"",
                ""PlusName"": ""Paramount"",
                ""Country"": ""美国"",
                ""Category"": ""AV"",
                ""Grade"": 6,
                ""Tip"": ""好莱坞八大电影公司之一，代表作品有：教父""
              },
              {
                ""ID"": 363,
                ""Name"": ""普拉达"",
                ""KeyName"": ""普拉达"",
                ""PlusName"": ""PRADA"",
                ""Country"": ""意大利"",
                ""Category"": ""Fashion"",
                ""Grade"": 6,
                ""Tip"": ""穿XXX的女王，于米兰诞生的奢侈品牌""
              },
              {
                ""ID"": 364,
                ""Name"": ""闪迪"",
                ""KeyName"": ""闪迪"",
                ""PlusName"": ""SanDisk"",
                ""Country"": ""美国"",
                ""Category"": ""Tech"",
                ""Grade"": 6,
                ""Tip"": ""全球最大的闪速数据存储卡产品供应商""
              },
              {
                ""ID"": 365,
                ""Name"": ""松下"",
                ""KeyName"": ""松下"",
                ""PlusName"": ""Panasonic"",
                ""Country"": ""日本"",
                ""Category"": ""Tech"",
                ""Grade"": 6,
                ""Tip"": ""世界500强，口号：A Better Life A Better World""
              },
              {
                ""ID"": 366,
                ""Name"": ""外星人"",
                ""KeyName"": ""外星人"",
                ""PlusName"": ""Alienware"",
                ""Country"": ""美国"",
                ""Category"": ""Tech"",
                ""Grade"": 6,
                ""Tip"": ""戴尔旗下高端游戏笔记本品牌""
              },
              {
                ""ID"": 367,
                ""Name"": ""维基百科"",
                ""KeyName"": ""维基百科"",
                ""PlusName"": ""Wikipedia"",
                ""Country"": ""美国"",
                ""Category"": ""Tech"",
                ""Grade"": 6,
                ""Tip"": ""基于维基技术的全球性多语言百科全书""
              },
              {
                ""ID"": 368,
                ""Name"": ""味千拉面"",
                ""KeyName"": ""味千拉面"",
                ""PlusName"": ""AJISEN PAMEN"",
                ""Country"": ""日本"",
                ""Category"": ""Cater"",
                ""Grade"": 6,
                ""Tip"": ""特色是拉面及日式美食""
              },
              {
                ""ID"": 369,
                ""Name"": ""五十铃"",
                ""KeyName"": ""五十铃"",
                ""PlusName"": ""Isuzu"",
                ""Country"": ""日本"",
                ""Category"": ""Car"",
                ""Grade"": 6,
                ""Tip"": ""以伊势神宫旁的xxx河来命名""
              },
              {
                ""ID"": 370,
                ""Name"": ""新百伦"",
                ""KeyName"": ""新百伦"",
                ""PlusName"": ""New Balance"",
                ""Country"": ""美国"",
                ""Category"": ""Fashion"",
                ""Grade"": 6,
                ""Tip"": ""美国运动品牌，被誉为：慢跑鞋之王""
              },
              {
                ""ID"": 371,
                ""Name"": ""兄弟"",
                ""KeyName"": ""兄弟"",
                ""PlusName"": ""Brother"",
                ""Country"": ""日本"",
                ""Category"": ""Tech"",
                ""Grade"": 6,
                ""Tip"": ""最初生产缝纫机，之后以打印机闻名""
              },
              {
                ""ID"": 372,
                ""Name"": ""安利"",
                ""KeyName"": ""安利"",
                ""PlusName"": ""Amway"",
                ""Country"": ""美国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 6,
                ""Tip"": ""高质量消费品品牌，衍生出同名的网络词汇，意为推荐""
              },
              {
                ""ID"": 373,
                ""Name"": ""捷豹"",
                ""KeyName"": ""捷豹"",
                ""PlusName"": ""Jaguar"",
                ""Country"": ""英国"",
                ""Category"": ""Car"",
                ""Grade"": 6,
                ""Tip"": ""豪车品牌，车标为一只正在跳跃前扑的美洲豹形象""
              },
              {
                ""ID"": 374,
                ""Name"": ""阿尔法罗密欧"",
                ""KeyName"": ""阿尔法罗密欧"",
                ""PlusName"": ""Alfa Romeo"",
                ""Country"": ""意大利"",
                ""Category"": ""Car"",
                ""Grade"": 6,
                ""Tip"": ""菲亚特FIAT集团旗下意大利著名的轿车和跑车制造商""
              },
              {
                ""ID"": 375,
                ""Name"": ""帕加尼"",
                ""KeyName"": ""帕加尼"",
                ""PlusName"": ""Pagani"",
                ""Country"": ""意大利"",
                ""Category"": ""Car"",
                ""Grade"": 6,
                ""Tip"": ""超跑品牌，同法拉利一样诞生于超跑之乡摩德纳""
              },
              {
                ""ID"": 376,
                ""Name"": ""狮门电影公司"",
                ""KeyName"": ""狮门"",
                ""PlusName"": ""LIONSGATE"",
                ""Country"": ""加拿大"",
                ""Category"": ""AV"",
                ""Grade"": 6,
                ""Tip"": ""加拿大的娱乐公司，创始人弗兰克古斯塔""
              },
              {
                ""ID"": 377,
                ""Name"": ""传奇影业"",
                ""KeyName"": ""传奇"",
                ""PlusName"": ""Legendary Pictures"",
                ""Country"": ""美国"",
                ""Category"": ""AV"",
                ""Grade"": 6,
                ""Tip"": ""发行过蝙蝠侠系列电影，16年被万达集团收购""
              },
              {
                ""ID"": 378,
                ""Name"": ""顶峰娱乐"",
                ""KeyName"": ""顶峰"",
                ""PlusName"": ""Summit Entertainment"",
                ""Country"": ""美国"",
                ""Category"": ""AV"",
                ""Grade"": 6,
                ""Tip"": ""发行过拆弹部队等，后被狮门电影收购""
              },
              {
                ""ID"": 379,
                ""Name"": ""新邦物流"",
                ""KeyName"": ""新邦"",
                ""PlusName"": ""xb"",
                ""Country"": ""中国"",
                ""Category"": ""Walking"",
                ""Grade"": 6,
                ""Tip"": ""物流公司，口号：心传递，新价值""
              },
              {
                ""ID"": 380,
                ""Name"": ""AE美国鹰"",
                ""KeyName"": ""美国鹰"",
                ""PlusName"": ""American Eagle"",
                ""Country"": ""美国"",
                ""Category"": ""Fashion"",
                ""Grade"": 6,
                ""Tip"": ""美国街头至IN的一个品牌""
              },
              {
                ""ID"": 381,
                ""Name"": ""汉庭酒店"",
                ""KeyName"": ""汉庭"",
                ""PlusName"": ""HANTING INNS\u0026HOTELS"",
                ""Country"": ""中国"",
                ""Category"": ""Walking"",
                ""Grade"": 6,
                ""Tip"": ""标准化的经济型酒店，创始人：季琦""
              },
              {
                ""ID"": 382,
                ""Name"": ""百思买"",
                ""KeyName"": ""百思买"",
                ""PlusName"": ""Best Buy"",
                ""Country"": ""美国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 6,
                ""Tip"": ""全球最大家用电器和电子产品零售集团""
              },
              {
                ""ID"": 383,
                ""Name"": ""汾酒"",
                ""KeyName"": ""汾酒"",
                ""PlusName"": ""-"",
                ""Country"": ""中国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 6,
                ""Tip"": ""四大名酒之一，产于山西""
              },
              {
                ""ID"": 384,
                ""Name"": ""好又多"",
                ""KeyName"": ""好又多"",
                ""PlusName"": ""TRUST-MART"",
                ""Country"": ""中国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 6,
                ""Tip"": ""中国大陆连锁分店数量最多的外资商业企业""
              },
              {
                ""ID"": 385,
                ""Name"": ""麦德龙"",
                ""KeyName"": ""麦德龙"",
                ""PlusName"": ""METRO"",
                ""Country"": ""德国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 6,
                ""Tip"": ""德国最大、欧洲第二的零售批发超市集团""
              },
              {
                ""ID"": 386,
                ""Name"": ""茅台"",
                ""KeyName"": ""茅台"",
                ""PlusName"": ""moutai"",
                ""Country"": ""中国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 6,
                ""Tip"": ""四大名酒之一，产于贵州，世界三大蒸馏名酒之一""
              },
              {
                ""ID"": 387,
                ""Name"": ""希尔顿"",
                ""KeyName"": ""希尔顿"",
                ""PlusName"": ""Hilton"",
                ""Country"": ""美国"",
                ""Category"": ""Walking"",
                ""Grade"": 6,
                ""Tip"": ""美国旅馆业巨头，人称旅店帝王""
              },
              {
                ""ID"": 388,
                ""Name"": ""亚马逊"",
                ""KeyName"": ""亚马逊"",
                ""PlusName"": ""Amazon"",
                ""Country"": ""美国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 6,
                ""Tip"": ""美国最大的一家网络电子商务公司""
              },
              {
                ""ID"": 389,
                ""Name"": ""中国人民银行"",
                ""KeyName"": ""央行"",
                ""PlusName"": ""PBOC"",
                ""Country"": ""中国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 6,
                ""Tip"": ""中华人民共和国的中央银行""
              },
              {
                ""ID"": 390,
                ""Name"": ""香奈儿"",
                ""KeyName"": ""香奈儿"",
                ""PlusName"": ""CHANEL"",
                ""Country"": ""法国"",
                ""Category"": ""Fashion"",
                ""Grade"": 6,
                ""Tip"": ""口号：流行稍纵即逝，风格永存""
              },
              {
                ""ID"": 391,
                ""Name"": ""吉野家"",
                ""KeyName"": ""吉野家"",
                ""PlusName"": ""Yoshinoya"",
                ""Country"": ""日本"",
                ""Category"": ""Cater"",
                ""Grade"": 6,
                ""Tip"": ""著名日本牛肉饭专门店，创始人：松田荣吉""
              },
              {
                ""ID"": 392,
                ""Name"": ""VISA"",
                ""KeyName"": ""维信"",
                ""PlusName"": ""维萨"",
                ""Country"": ""美国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 6,
                ""Tip"": ""信用卡品牌，前身是由美洲银行所发行的Bank Americard""
              },
              {
                ""ID"": 393,
                ""Name"": ""万事达卡"",
                ""KeyName"": ""万卡"",
                ""PlusName"": ""MasterCard"",
                ""Country"": ""美国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 6,
                ""Tip"": ""信用卡品牌，原名MasterCharge""
              },
              {
                ""ID"": 394,
                ""Name"": ""上岛咖啡"",
                ""KeyName"": ""上岛咖啡"",
                ""PlusName"": ""Uegashima coffee"",
                ""Country"": ""中国"",
                ""Category"": ""Cater"",
                ""Grade"": 6,
                ""Tip"": ""国内著名的咖啡连锁餐厅，口号：源于台湾、香闻世界""
              },
              {
                ""ID"": 395,
                ""Name"": ""名爵"",
                ""KeyName"": ""MG"",
                ""PlusName"": ""MORRIS GARAGE"",
                ""Country"": ""中国/英国"",
                ""Category"": ""Car"",
                ""Grade"": 6,
                ""Tip"": ""简称MG，八角形形状标志，象征着热情、忠诚""
              },
              {
                ""ID"": 396,
                ""Name"": ""匡威"",
                ""KeyName"": ""匡威"",
                ""PlusName"": ""Converse"",
                ""Country"": ""美国"",
                ""Category"": ""Fashion"",
                ""Grade"": 6,
                ""Tip"": ""集复古、流行、环保于一身的ALL STAR帆布鞋""
              },
              {
                ""ID"": 397,
                ""Name"": ""飞人乔丹"",
                ""KeyName"": ""飞人乔丹"",
                ""PlusName"": ""AIR JORDAN"",
                ""Country"": ""美国"",
                ""Category"": ""Fashion"",
                ""Grade"": 6,
                ""Tip"": ""以史上最著名的NBA球星迈克尔乔丹命名的系列""
              },
              {
                ""ID"": 398,
                ""Name"": ""威图"",
                ""KeyName"": ""纬图"",
                ""PlusName"": ""Vertu"",
                ""Country"": ""芬兰"",
                ""Category"": ""Fashion"",
                ""Grade"": 6,
                ""Tip"": ""诺基亚所成立的全球第一家奢侈手机公司""
              },
              {
                ""ID"": 399,
                ""Name"": ""AMC电视台"",
                ""KeyName"": ""AMC"",
                ""PlusName"": ""-"",
                ""Country"": ""美国"",
                ""Category"": ""AV"",
                ""Grade"": 6,
                ""Tip"": ""美国有线电视台，出品过行尸走肉、绝命毒师等美剧""
              },
              {
                ""ID"": 400,
                ""Name"": ""古驰"",
                ""KeyName"": ""古驰"",
                ""PlusName"": ""Gucci"",
                ""Country"": ""意大利"",
                ""Category"": ""Fashion"",
                ""Grade"": 6,
                ""Tip"": ""意大利最大的时装集团""
              },
              {
                ""ID"": 401,
                ""Name"": ""纳智捷"",
                ""KeyName"": ""纳智捷"",
                ""PlusName"": ""Luxgen"",
                ""Country"": ""中国"",
                ""Category"": ""Car"",
                ""Grade"": 6,
                ""Tip"": ""台湾最大的汽车企业裕隆集团与大陆合资成立之公司""
              },
              {
                ""ID"": 402,
                ""Name"": ""漫步者"",
                ""KeyName"": ""漫步者"",
                ""PlusName"": ""EDIFIER"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 6,
                ""Tip"": ""目前国内第一、全球第二大专业多媒体音响企业""
              },
              {
                ""ID"": 403,
                ""Name"": ""AKG"",
                ""KeyName"": ""AKG"",
                ""PlusName"": ""爱科技"",
                ""Country"": ""奥地利"",
                ""Category"": ""Tech"",
                ""Grade"": 6,
                ""Tip"": ""奥地利声乐设备品牌，世界四大耳机品牌之一""
              },
              {
                ""ID"": 404,
                ""Name"": ""Grado"",
                ""KeyName"": ""Grado"",
                ""PlusName"": ""歌德"",
                ""Country"": ""美国"",
                ""Category"": ""Tech"",
                ""Grade"": 6,
                ""Tip"": ""美国最著名的耳机及唱头生产厂，世界四大耳机品牌之一""
              },
              {
                ""ID"": 405,
                ""Name"": ""Filco"",
                ""KeyName"": ""Filco"",
                ""PlusName"": ""斐尔可"",
                ""Country"": ""日本"",
                ""Category"": ""Tech"",
                ""Grade"": 6,
                ""Tip"": ""日本DIATEC电气集团旗下知名机械键盘品牌""
              },
              {
                ""ID"": 406,
                ""Name"": ""马克华菲"",
                ""KeyName"": ""马克华菲"",
                ""PlusName"": ""Mark Fairwhale"",
                ""Country"": ""中国"",
                ""Category"": ""Fashion"",
                ""Grade"": 6,
                ""Tip"": ""Mark Cheung为世界都市新贵度身定制的中国原创设计时尚品牌""
              },
              {
                ""ID"": 407,
                ""Name"": ""影驰"",
                ""KeyName"": ""影驰"",
                ""PlusName"": ""GALAXY Microsystems"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 6,
                ""Tip"": ""嘉威科技的系列品牌产品，中高端优质显卡制造商""
              },
              {
                ""ID"": 408,
                ""Name"": ""微星"",
                ""KeyName"": ""微星"",
                ""PlusName"": ""MSI"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 6,
                ""Tip"": ""球前五大主板厂商之一和第一大显示卡生产商""
              },
              {
                ""ID"": 409,
                ""Name"": ""NEC"",
                ""KeyName"": ""日本电气"",
                ""PlusName"": ""日本电气股份有限公司"",
                ""Country"": ""日本"",
                ""Category"": ""Tech"",
                ""Grade"": 6,
                ""Tip"": ""在台湾被称为恩益禧，是日本一家跨国信息技术公司""
              },
              {
                ""ID"": 410,
                ""Name"": ""格兰仕"",
                ""KeyName"": ""格兰仕"",
                ""PlusName"": ""Galanz"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 6,
                ""Tip"": ""全球最大专业化微波炉制造商""
              },
              {
                ""ID"": 411,
                ""Name"": ""成功"",
                ""KeyName"": ""成功"",
                ""PlusName"": ""-"",
                ""Country"": ""中国"",
                ""Category"": ""Car"",
                ""Grade"": 6,
                ""Tip"": ""中国汽车品牌，主要生产皮卡、轻型车""
              },
              {
                ""ID"": 412,
                ""Name"": ""斯柯达"",
                ""KeyName"": ""斯柯达"",
                ""PlusName"": ""SKODA"",
                ""Country"": ""捷克"",
                ""Category"": ""Car"",
                ""Grade"": 7,
                ""Tip"": ""位于捷克的世界上历史最悠久的四家汽车生产商之一""
              },
              {
                ""ID"": 413,
                ""Name"": ""西雅特"",
                ""KeyName"": ""西雅特"",
                ""PlusName"": ""Seat"",
                ""Country"": ""西班牙"",
                ""Category"": ""Car"",
                ""Grade"": 7,
                ""Tip"": ""西班牙最大的汽车公司""
              },
              {
                ""ID"": 414,
                ""Name"": ""斯巴鲁"",
                ""KeyName"": ""斯巴鲁"",
                ""PlusName"": ""Subaru"",
                ""Country"": ""日本"",
                ""Category"": ""Car"",
                ""Grade"": 7,
                ""Tip"": ""富士重工旗下，六连星标志""
              },
              {
                ""ID"": 415,
                ""Name"": ""科尼赛克"",
                ""KeyName"": ""科尼赛克"",
                ""PlusName"": ""Koenigsegg"",
                ""Country"": ""瑞典"",
                ""Category"": ""Car"",
                ""Grade"": 7,
                ""Tip"": ""瑞典超级跑车制造厂，幽灵图案logo""
              },
              {
                ""ID"": 416,
                ""Name"": ""阿斯顿马丁"",
                ""KeyName"": ""阿斯顿马丁"",
                ""PlusName"": ""AstonMartin"",
                ""Country"": ""英国"",
                ""Category"": ""Car"",
                ""Grade"": 7,
                ""Tip"": ""其标志是一只展翅飞翔的大鹏""
              },
              {
                ""ID"": 417,
                ""Name"": ""爱马仕"",
                ""KeyName"": ""爱马仕"",
                ""PlusName"": ""Hermes"",
                ""Country"": ""法国"",
                ""Category"": ""Fashion"",
                ""Grade"": 7,
                ""Tip"": ""法国著名奢侈品品牌，以制造高级马具起家""
              },
              {
                ""ID"": 418,
                ""Name"": ""宾利"",
                ""KeyName"": ""宾利"",
                ""PlusName"": ""Bentley"",
                ""Country"": ""英国"",
                ""Category"": ""Car"",
                ""Grade"": 7,
                ""Tip"": ""著名豪车制造商，98被大众集团收购""
              },
              {
                ""ID"": 419,
                ""Name"": ""布加迪"",
                ""KeyName"": ""布加迪"",
                ""PlusName"": ""Bugatti"",
                ""Country"": ""法国"",
                ""Category"": ""Car"",
                ""Grade"": 7,
                ""Tip"": ""法国跑车品牌，98被大众集团收购""
              },
              {
                ""ID"": 420,
                ""Name"": ""大疆"",
                ""KeyName"": ""大疆"",
                ""PlusName"": ""-"",
                ""Country"": ""中国"",
                ""Category"": ""Tech"",
                ""Grade"": 7,
                ""Tip"": ""一夜成名的无人机品牌，创始人：汪滔""
              },
              {
                ""ID"": 421,
                ""Name"": ""NXP"",
                ""KeyName"": ""恩智浦"",
                ""PlusName"": ""恩智浦"",
                ""Country"": ""荷兰"",
                ""Category"": ""Tech"",
                ""Grade"": 7,
                ""Tip"": ""由飞利浦公司创立的半导体公司，后与飞思卡尔合并""
              },
              {
                ""ID"": 422,
                ""Name"": ""范思哲"",
                ""KeyName"": ""范思哲"",
                ""PlusName"": ""Versace"",
                ""Country"": ""意大利"",
                ""Category"": ""Fashion"",
                ""Grade"": 7,
                ""Tip"": ""标志是神话中的蛇妖美杜莎，代表着致命的吸引力""
              },
              {
                ""ID"": 423,
                ""Name"": ""芬迪"",
                ""KeyName"": ""芬迪"",
                ""PlusName"": ""FENDI"",
                ""Country"": ""意大利"",
                ""Category"": ""Fashion"",
                ""Grade"": 7,
                ""Tip"": ""意大利奢侈品品牌，以一家位于罗马的皮革毛皮商店起家""
              },
              {
                ""ID"": 424,
                ""Name"": ""光冈"",
                ""KeyName"": ""光冈"",
                ""PlusName"": ""MITSUOKA"",
                ""Country"": ""日本"",
                ""Category"": ""Car"",
                ""Grade"": 7,
                ""Tip"": ""主要生产改装轿车，logo来源于古汉字：车""
              },
              {
                ""ID"": 425,
                ""Name"": ""海盗船"",
                ""KeyName"": ""海盗船"",
                ""PlusName"": ""Corsair"",
                ""Country"": ""美国"",
                ""Category"": ""Tech"",
                ""Grade"": 7,
                ""Tip"": ""著名电脑硬件制造商，全球最受尊敬的超频内存制造商""
              },
              {
                ""ID"": 426,
                ""Name"": ""海滋客"",
                ""KeyName"": ""海滋客"",
                ""PlusName"": ""Long John Silver\u0027s"",
                ""Country"": ""美国"",
                ""Category"": ""Cater"",
                ""Grade"": 7,
                ""Tip"": ""国际连锁速食餐厅，以海鲜、炸鱼块为其主要特色""
              },
              {
                ""ID"": 427,
                ""Name"": ""卡地亚"",
                ""KeyName"": ""卡地亚"",
                ""PlusName"": ""Cartier"",
                ""Country"": ""法国"",
                ""Category"": ""Fashion"",
                ""Grade"": 7,
                ""Tip"": ""世界上首只戴在手腕的腕表""
              },
              {
                ""ID"": 428,
                ""Name"": ""柯尼卡美能达"",
                ""KeyName"": ""柯尼卡美能达"",
                ""PlusName"": ""Konica Minolta"",
                ""Country"": ""日本"",
                ""Category"": ""Tech"",
                ""Grade"": 7,
                ""Tip"": ""在中国以大型打印机闻名，企业口号：The essentials of imaging""
              },
              {
                ""ID"": 429,
                ""Name"": ""蓝天工作室"",
                ""KeyName"": ""蓝天"",
                ""PlusName"": ""Blue sky"",
                ""Country"": ""美国"",
                ""Category"": ""AV"",
                ""Grade"": 7,
                ""Tip"": ""好莱坞著名动画工作室，出品有冰河世纪""
              },
              {
                ""ID"": 430,
                ""Name"": ""联美"",
                ""KeyName"": ""联美"",
                ""PlusName"": ""United Artists"",
                ""Country"": ""美国"",
                ""Category"": ""AV"",
                ""Grade"": 7,
                ""Tip"": ""好莱坞八大电影公司之一，现东家为汤姆·克鲁斯""
              },
              {
                ""ID"": 431,
                ""Name"": ""林肯"",
                ""KeyName"": ""林肯"",
                ""PlusName"": ""LINCOLN"",
                ""Country"": ""美国"",
                ""Category"": ""Car"",
                ""Grade"": 7,
                ""Tip"": ""福特旗下豪华汽车品牌，以一位美国总统名字命名""
              },
              {
                ""ID"": 432,
                ""Name"": ""美国联合航空"",
                ""KeyName"": ""美联航"",
                ""PlusName"": ""United Airlines"",
                ""Country"": ""美国"",
                ""Category"": ""Walking"",
                ""Grade"": 7,
                ""Tip"": ""隶属于星空联盟，口号：翱游天际，友善体验""
              },
              {
                ""ID"": 433,
                ""Name"": ""米高梅"",
                ""KeyName"": ""米高梅"",
                ""PlusName"": ""Metro-Goldwyn-Mayer"",
                ""Country"": ""美国"",
                ""Category"": ""AV"",
                ""Grade"": 7,
                ""Tip"": ""好莱坞八大电影公司之一，发起并推出了奥斯卡奖""
              },
              {
                ""ID"": 434,
                ""Name"": ""皮克斯"",
                ""KeyName"": ""皮克斯"",
                ""PlusName"": ""Pixar"",
                ""Country"": ""美国"",
                ""Category"": ""AV"",
                ""Grade"": 7,
                ""Tip"": ""迪士尼旗下顶级动画工作室，曾是卢卡斯电影公司的电脑动画部""
              },
              {
                ""ID"": 435,
                ""Name"": ""日立"",
                ""KeyName"": ""日立"",
                ""PlusName"": ""HITACHI"",
                ""Country"": ""日本"",
                ""Category"": ""Tech"",
                ""Grade"": 7,
                ""Tip"": ""日本的一家全球最大的综合跨国集团""
              },
              {
                ""ID"": 436,
                ""Name"": ""软银"",
                ""KeyName"": ""软银"",
                ""PlusName"": ""SoftBank"",
                ""Country"": ""日本"",
                ""Category"": ""Tech"",
                ""Grade"": 7,
                ""Tip"": ""由孙正义成立的综合性的风险投资公司""
              },
              {
                ""ID"": 437,
                ""Name"": ""赛麟"",
                ""KeyName"": ""赛麟"",
                ""PlusName"": ""Saleen"",
                ""Country"": ""美国"",
                ""Category"": ""Car"",
                ""Grade"": 7,
                ""Tip"": ""世界超跑之王，无可比拟的外观设计与巅峰性能""
              },
              {
                ""ID"": 438,
                ""Name"": ""施乐"",
                ""KeyName"": ""施乐"",
                ""PlusName"": ""Xerox"",
                ""Country"": ""美国"",
                ""Category"": ""Tech"",
                ""Grade"": 7,
                ""Tip"": ""全球最大数字与信息技术产品生产商，复印技术的发明公司""
              },
              {
                ""ID"": 439,
                ""Name"": ""塔可钟"",
                ""KeyName"": ""塔可钟"",
                ""PlusName"": ""tacobell"",
                ""Country"": ""美国"",
                ""Category"": ""Cater"",
                ""Grade"": 7,
                ""Tip"": ""世界上规模最大的提供墨西哥式食品的连锁餐饮品牌""
              },
              {
                ""ID"": 440,
                ""Name"": ""泰卡特"",
                ""KeyName"": ""泰卡特"",
                ""PlusName"": ""TECHART"",
                ""Country"": ""德国"",
                ""Category"": ""Car"",
                ""Grade"": 7,
                ""Tip"": ""个性化汽车国际品牌，logo为持金钥匙的狮鹫和狮鹫""
              },
              {
                ""ID"": 441,
                ""Name"": ""唐恩都乐"",
                ""KeyName"": ""唐恩都乐"",
                ""PlusName"": ""Dunkin Donuts"",
                ""Country"": ""美国"",
                ""Category"": ""Cater"",
                ""Grade"": 7,
                ""Tip"": ""美国十大快餐连锁品牌之一，别名当肯甜甜圈""
              },
              {
                ""ID"": 442,
                ""Name"": ""威兹曼"",
                ""KeyName"": ""威兹曼"",
                ""PlusName"": ""Wiesmann"",
                ""Country"": ""德国"",
                ""Category"": ""Car"",
                ""Grade"": 7,
                ""Tip"": ""德国最小的整车生产厂，外观仿古而内部却极其现代化""
              },
              {
                ""ID"": 443,
                ""Name"": ""西部数据"",
                ""KeyName"": ""西数"",
                ""PlusName"": ""Western Digital"",
                ""Country"": ""美国"",
                ""Category"": ""Tech"",
                ""Grade"": 7,
                ""Tip"": ""全球第二大硬盘生产商""
              },
              {
                ""ID"": 444,
                ""Name"": ""希捷"",
                ""KeyName"": ""希捷"",
                ""PlusName"": ""Seagate"",
                ""Country"": ""美国"",
                ""Category"": ""Tech"",
                ""Grade"": 7,
                ""Tip"": ""全球最大的硬盘、磁盘和读写磁头制造商""
              },
              {
                ""ID"": 445,
                ""Name"": ""骁龙"",
                ""KeyName"": ""骁龙"",
                ""PlusName"": ""Snapdragon"",
                ""Country"": ""美国"",
                ""Category"": ""Tech"",
                ""Grade"": 7,
                ""Tip"": ""Qualcomm旗下移动处理器和LTE调制解调器的品牌名""
              },
              {
                ""ID"": 446,
                ""Name"": ""意法半导体"",
                ""KeyName"": ""意法"",
                ""PlusName"": ""ST"",
                ""Country"": ""意大利/法国"",
                ""Category"": ""Tech"",
                ""Grade"": 7,
                ""Tip"": ""全球第五大半导体厂商""
              },
              {
                ""ID"": 447,
                ""Name"": ""Artega"",
                ""KeyName"": ""Artega"",
                ""PlusName"": ""-"",
                ""Country"": ""德国"",
                ""Category"": ""Car"",
                ""Grade"": 7,
                ""Tip"": ""德国新兴跑车品牌，动力由来自大众的3.6升V6发动机提供""
              },
              {
                ""ID"": 448,
                ""Name"": ""AC Schnitzer"",
                ""KeyName"": ""AC Schnitzer"",
                ""PlusName"": ""-"",
                ""Country"": ""德国"",
                ""Category"": ""Car"",
                ""Grade"": 7,
                ""Tip"": ""全世界最大的BMW专业改装厂""
              },
              {
                ""ID"": 449,
                ""Name"": ""杰瑞·布鲁克海默电影公司"",
                ""KeyName"": ""杰瑞布鲁克海默"",
                ""PlusName"": ""Jerry Bruckheimer Films"",
                ""Country"": ""美国"",
                ""Category"": ""AV"",
                ""Grade"": 7,
                ""Tip"": ""有同名好莱坞制片人（如加勒比海盗）创立""
              },
              {
                ""ID"": 450,
                ""Name"": ""孩之宝"",
                ""KeyName"": ""孩之宝"",
                ""PlusName"": ""Hasbro"",
                ""Country"": ""美国"",
                ""Category"": ""AV"",
                ""Grade"": 7,
                ""Tip"": ""著名玩具公司、旗下有变形金刚等著名品牌""
              },
              {
                ""ID"": 451,
                ""Name"": ""全峰快递"",
                ""KeyName"": ""全峰"",
                ""PlusName"": ""Quanfeng"",
                ""Country"": ""中国"",
                ""Category"": ""Walking"",
                ""Grade"": 7,
                ""Tip"": ""口号：成为中国快递综合解决方案领跑者""
              },
              {
                ""ID"": 452,
                ""Name"": ""国泰航空"",
                ""KeyName"": ""国泰航空"",
                ""PlusName"": ""Cathay Pacific Airways"",
                ""Country"": ""中国"",
                ""Category"": ""Walking"",
                ""Grade"": 7,
                ""Tip"": ""香港第一所提供民航服务的航空公司""
              },
              {
                ""ID"": 453,
                ""Name"": ""纪梵希"",
                ""KeyName"": ""纪梵希"",
                ""PlusName"": ""Givenchy"",
                ""Country"": ""法国"",
                ""Category"": ""Fashion"",
                ""Grade"": 7,
                ""Tip"": ""法国的时装品牌，其4G标志代表：古典 、优雅 、愉悦以及其品牌名""
              },
              {
                ""ID"": 454,
                ""Name"": ""路易威登"",
                ""KeyName"": ""路易威登"",
                ""PlusName"": ""LouisVuitton"",
                ""Country"": ""法国"",
                ""Category"": ""Fashion"",
                ""Grade"": 7,
                ""Tip"": ""著名奢侈品品牌，俗称lv""
              },
              {
                ""ID"": 455,
                ""Name"": ""大润发"",
                ""KeyName"": ""大润发"",
                ""PlusName"": ""RT-MART"",
                ""Country"": ""中国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 7,
                ""Tip"": ""RT-MART，台湾大型连锁量贩店""
              },
              {
                ""ID"": 456,
                ""Name"": ""泸州老窖"",
                ""KeyName"": ""泸州老窖"",
                ""PlusName"": ""-"",
                ""Country"": ""中国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 7,
                ""Tip"": ""四大名酒之一，产于四川，浓香鼻祖、酒中泰斗""
              },
              {
                ""ID"": 457,
                ""Name"": ""欧尚"",
                ""KeyName"": ""欧尚"",
                ""PlusName"": ""Auchan"",
                ""Country"": ""法国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 7,
                ""Tip"": ""法国第二大以经营零售业为主的商业集团，全球十大零售商之一""
              },
              {
                ""ID"": 458,
                ""Name"": ""西凤酒"",
                ""KeyName"": ""西凤酒"",
                ""PlusName"": ""-"",
                ""Country"": ""中国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 7,
                ""Tip"": ""四大名酒之一，产于陕西""
              },
              {
                ""ID"": 459,
                ""Name"": ""宜家"",
                ""KeyName"": ""宜家"",
                ""PlusName"": ""IKEA"",
                ""Country"": ""瑞典"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 7,
                ""Tip"": ""全球最大的家具家居用品商家""
              },
              {
                ""ID"": 460,
                ""Name"": ""易买得"",
                ""KeyName"": ""易买得"",
                ""PlusName"": ""e-smart"",
                ""Country"": ""韩国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 7,
                ""Tip"": ""韩国新世界集团旗下的大型综合超市""
              },
              {
                ""ID"": 461,
                ""Name"": ""和路雪"",
                ""KeyName"": ""和路雪"",
                ""PlusName"": ""Wall\u0027s"",
                ""Country"": ""荷兰/英国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 7,
                ""Tip"": ""英国著名冰激凌企业，联合利华旗下品牌""
              },
              {
                ""ID"": 462,
                ""Name"": ""尊尼获加"",
                ""KeyName"": ""尊尼获加"",
                ""PlusName"": ""Johnnie Walker"",
                ""Country"": ""英国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 7,
                ""Tip"": ""世界著名的苏格兰威士忌品牌，又译约翰走路""
              },
              {
                ""ID"": 463,
                ""Name"": ""JCB信用卡"",
                ""KeyName"": ""JCB信用卡"",
                ""PlusName"": ""JCB"",
                ""Country"": ""日本"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 7,
                ""Tip"": ""源自日本的世界通用国际信用卡""
              },
              {
                ""ID"": 464,
                ""Name"": ""维塔数码"",
                ""KeyName"": ""维塔"",
                ""PlusName"": ""Weta Digital"",
                ""Country"": ""美国"",
                ""Category"": ""AV"",
                ""Grade"": 7,
                ""Tip"": ""彼得杰克逊等人创建，指环王、阿凡达视效制作团队""
              },
              {
                ""ID"": 465,
                ""Name"": ""宝腾"",
                ""KeyName"": ""宝腾"",
                ""PlusName"": ""PROTON"",
                ""Country"": ""马来西亚"",
                ""Category"": ""Car"",
                ""Grade"": 7,
                ""Tip"": ""马来西亚国产汽车品牌，后收购了英国的LOTUS""
              },
              {
                ""ID"": 466,
                ""Name"": ""迈巴赫"",
                ""KeyName"": ""迈巴赫"",
                ""PlusName"": ""Maybach"",
                ""Country"": ""韩国"",
                ""Category"": ""Car"",
                ""Grade"": 7,
                ""Tip"": ""曾在1921到1940间活跃于欧洲地区的德国超豪华汽车品牌与制造厂""
              },
              {
                ""ID"": 467,
                ""Name"": ""纳努"",
                ""KeyName"": ""塔塔家族"",
                ""PlusName"": ""TATA"",
                ""Country"": ""印度"",
                ""Category"": ""Car"",
                ""Grade"": 7,
                ""Tip"": ""印度第一大商业世家""
              },
              {
                ""ID"": 468,
                ""Name"": ""美津浓"",
                ""KeyName"": ""美津浓"",
                ""PlusName"": ""Mizuno"",
                ""Country"": ""日本"",
                ""Category"": ""Fashion"",
                ""Grade"": 7,
                ""Tip"": ""日本知名运动品牌，其商标叫米奇巴希利，是世界上跑的最快的鸟""
              },
              {
                ""ID"": 469,
                ""Name"": ""茵宝"",
                ""KeyName"": ""茵宝"",
                ""PlusName"": ""UMBRO"",
                ""Country"": ""英国"",
                ""Category"": ""Fashion"",
                ""Grade"": 7,
                ""Tip"": ""专业足球服装及装备供应商，创始人：堪富利士兄弟""
              },
              {
                ""ID"": 470,
                ""Name"": ""亚瑟士"",
                ""KeyName"": ""亚瑟士"",
                ""PlusName"": ""Asics"",
                ""Country"": ""日本"",
                ""Category"": ""Fashion"",
                ""Grade"": 7,
                ""Tip"": ""日本大家鬼冢八喜郎创立的跑鞋运动品牌""
              },
              {
                ""ID"": 471,
                ""Name"": ""中铁快运"",
                ""KeyName"": ""中铁快运"",
                ""PlusName"": ""China Railway Express"",
                ""Country"": ""中国"",
                ""Category"": ""Walking"",
                ""Grade"": 7,
                ""Tip"": ""铁道部直属大型国有专业运输企业""
              },
              {
                ""ID"": 472,
                ""Name"": ""寰亚"",
                ""KeyName"": ""寰亚"",
                ""PlusName"": ""Media Asia Group"",
                ""Country"": ""中国"",
                ""Category"": ""AV"",
                ""Grade"": 7,
                ""Tip"": ""亚洲最大及最成功的华语电影制作公司之一""
              },
              {
                ""ID"": 473,
                ""Name"": ""华伦天奴"",
                ""KeyName"": ""华伦天奴"",
                ""PlusName"": ""Valentino"",
                ""Country"": ""意大利"",
                ""Category"": ""Fashion"",
                ""Grade"": 7,
                ""Tip"": ""全球高级定制和高级成衣奢侈品品牌""
              },
              {
                ""ID"": 474,
                ""Name"": ""酩悦香槟"",
                ""KeyName"": ""酩悦香槟"",
                ""PlusName"": ""Moet \u0026 Chandon"",
                ""Country"": ""法国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 7,
                ""Tip"": ""全球最受欢迎的香槟品牌，已有270多年历史""
              },
              {
                ""ID"": 475,
                ""Name"": ""拜亚动力"",
                ""KeyName"": ""拜亚"",
                ""PlusName"": ""beyerdynamic"",
                ""Country"": ""德国"",
                ""Category"": ""Tech"",
                ""Grade"": 7,
                ""Tip"": ""世界四大耳机品牌之一，被尊称为耳机之父""
              },
              {
                ""ID"": 476,
                ""Name"": ""森海塞尔"",
                ""KeyName"": ""声海"",
                ""PlusName"": ""Sennheiser"",
                ""Country"": ""德国"",
                ""Category"": ""Tech"",
                ""Grade"": 7,
                ""Tip"": ""世界四大耳机品牌之一，张靓颖曾获其品牌授予的：亚洲地区唯一声音大使""
              },
              {
                ""ID"": 477,
                ""Name"": ""京瓷"",
                ""KeyName"": ""京瓷"",
                ""PlusName"": ""KYOCERA"",
                ""Country"": ""日本"",
                ""Category"": ""Tech"",
                ""Grade"": 7,
                ""Tip"": ""横跨多个领域的日本企业，创始人：稻盛和夫""
              },
              {
                ""ID"": 478,
                ""Name"": ""富国银行"",
                ""KeyName"": ""富国"",
                ""PlusName"": ""Wells Fargo"",
                ""Country"": ""美国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 7,
                ""Tip"": ""全球市值最高银行""
              },
              {
                ""ID"": 479,
                ""Name"": ""美国运通"",
                ""KeyName"": ""美国运通"",
                ""PlusName"": ""American Express"",
                ""Country"": ""美国"",
                ""Category"": ""Walking"",
                ""Grade"": 7,
                ""Tip"": ""国际上最大的旅游服务及综合性财务、金融投资及信息处理的环球公司""
              },
              {
                ""ID"": 480,
                ""Name"": ""汇丰集团"",
                ""KeyName"": ""汇丰"",
                ""PlusName"": ""HSBC"",
                ""Country"": ""英国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 7,
                ""Tip"": ""总部位于伦敦，全球规模最大的银行及金融机构之一""
              },
              {
                ""ID"": 481,
                ""Name"": ""加拿大皇家银行"",
                ""KeyName"": ""加拿大皇家银行"",
                ""PlusName"": ""Royal Bank of Canada"",
                ""Country"": ""加拿大"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 7,
                ""Tip"": ""加拿大市值最高、资产最大的银行""
              },
              {
                ""ID"": 482,
                ""Name"": ""渣打银行"",
                ""KeyName"": ""渣打"",
                ""PlusName"": ""Standard Chartered Bank"",
                ""Country"": ""英国"",
                ""Category"": ""Lifestyle"",
                ""Grade"": 7,
                ""Tip"": ""一家建于1853年，总部在伦敦的英国银行""
              }
            ]
            ";
            return json;
        }
    }
}
