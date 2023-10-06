﻿namespace DevHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class states_data : DbMigration
    {
        public override void Up()
        {
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				"(101,'Andaman and Nicobar Islands')," +
				"(101,'Andhra Pradesh')," +
				"(101,'Arunachal Pradesh')," +
				"(101,'Assam')," +
				"(101,'Bihar')," +
				"(101,'Chandigarh')," +
				"(101,'Chhattisgarh')," +
				"(101,'Dadra and Nagar Haveli')," +
				"(101,'Daman and Diu')," +
				"(101,'Delhi')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(101,'Goa')," +
				 "(101,'Gujarat')," +
				 "(101,'Haryana')," +
				 "(101,'Himachal Pradesh')," +
				 "(101,'Jammu and Kashmir')," +
				 "(101,'Jharkhand')," +
				 "(101,'Karnataka')," +
				 "(101,'Kenmore')," +
				 "(101,'Kerala')," +
				 "(101,'Lakshadweep')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(101,'Madhya Pradesh')," +
				 "(101,'Maharashtra')," +
				 "(101,'Manipur')," +
				 "(101,'Meghalaya')," +
				 "(101,'Mizoram')," +
				 "(101,'Nagaland')," +
				 "(101,'Narora')," +
				 "(101,'Natwar')," +
				 "(101,'Odisha')," +
				 "(101,'Paschim Medinipur')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(101,'Pondicherry')," +
				 "(101,'Punjab')," +
				 "(101,'Rajasthan')," +
				 "(101,'Sikkim')," +
				 "(101,'Tamil Nadu')," +
				 "(101,'Telangana')," +
				 "(101,'Tripura')," +
				 "(101,'Uttar Pradesh')," +
				 "(101,'Uttarakhand')," +
				 "(101,'Vaishali')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(101,'West Bengal')," +
				 "(1,'Badakhshan')," +
				 "(1,'Badgis')," +
				 "(1,'Baglan')," +
				 "(1,'Balkh')," +
				 "(1,'Bamiyan')," +
				 "(1,'Farah')," +
				 "(1,'Faryab')," +
				 "(1,'Gawr')," +
				 "(1,'Gazni')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(1,'Herat')," +
				 "(1,'Hilmand')," +
				 "(1,'Jawzjan')," +
				 "(1,'Kabul')," +
				 "(1,'Kapisa')," +
				 "(1,'Khawst')," +
				 "(1,'Kunar')," +
				 "(1,'Lagman')," +
				 "(1,'Lawghar')," +
				 "(1,'Nangarhar')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(1,'Nimruz')," +
				 "(1,'Nuristan')," +
				 "(1,'Paktika')," +
				 "(1,'Paktiya')," +
				 "(1,'Parwan')," +
				 "(1,'Qandahar')," +
				 "(1,'Qunduz')," +
				 "(1,'Samangan')," +
				 "(1,'Sar-e Pul')," +
				 "(1,'Takhar')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(1,'Uruzgan')," +
				 "(1,'Wardag')," +
				 "(1,'Zabul')," +
				 "(2,'Berat')," +
				 "(2,'Bulqize')," +
				 "(2,'Delvine')," +
				 "(2,'Devoll')," +
				 "(2,'Dibre')," +
				 "(2,'Durres')," +
				 "(2,'Elbasan')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(2,'Fier')," +
				 "(2,'Gjirokaster')," +
				 "(2,'Gramsh')," +
				 "(2,'Has')," +
				 "(2,'Kavaje')," +
				 "(2,'Kolonje')," +
				 "(2,'Korce')," +
				 "(2,'Kruje')," +
				 "(2,'Kucove')," +
				 "(2,'Kukes')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(2,'Kurbin')," +
				 "(2,'Lezhe')," +
				 "(2,'Librazhd')," +
				 "(2,'Lushnje')," +
				 "(2,'Mallakaster')," +
				 "(2,'Malsi e Madhe')," +
				 "(2,'Mat')," +
				 "(2,'Mirdite')," +
				 "(2,'Peqin')," +
				 "(2,'Permet')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(2,'Pogradec')," +
				 "(2,'Puke')," +
				 "(2,'Sarande')," +
				 "(2,'Shkoder')," +
				 "(2,'Skrapar')," +
				 "(2,'Tepelene')," +
				 "(2,'Tirane')," +
				 "(2,'Tropoje')," +
				 "(2,'Vlore')," +
				 "(3,'Ayn Daflah')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(3,'Ayn Tamushanat')," +
				 "(3,'Adrar')," +
				 "(3,'Algiers')," +
				 "(3,'Annabah')," +
				 "(3,'Bashshar')," +
				 "(3,'Batnah')," +
				 "(3,'Bijayah')," +
				 "(3,'Biskrah')," +
				 "(3,'Blidah')," +
				 "(3,'Buirah')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(3,'Bumardas')," +
				 "(3,'Burj Bu Arririj')," +
				 "(3,'Ghalizan')," +
				 "(3,'Ghardayah')," +
				 "(3,'Ilizi')," +
				 "(3,'Jijili')," +
				 "(3,'Jilfah')," +
				 "(3,'Khanshalah')," +
				 "(3,'Masilah')," +
				 "(3,'Midyah')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(3,'Milah')," +
				 "(3,'Muaskar')," +
				 "(3,'Mustaghanam')," +
				 "(3,'Naama')," +
				 "(3,'Oran')," +
				 "(3,'Ouargla')," +
				 "(3,'Qalmah')," +
				 "(3,'Qustantinah')," +
				 "(3,'Sakikdah')," +
				 "(3,'Satif')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(3,'Sayda')," +
				 "(3,'Sidi ban-al-Abbas')," +
				 "(3,'Suq Ahras')," +
				 "(3,'Tamanghasat')," +
				 "(3,'Tibazah')," +
				 "(3,'Tibissah')," +
				 "(3,'Tilimsan')," +
				 "(3,'Tinduf')," +
				 "(3,'Tisamsilt')," +
				 "(3,'Tiyarat')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(3,'Tizi Wazu')," +
				 "(3,'Umm-al-Bawaghi')," +
				 "(3,'Wahran')," +
				 "(3,'Warqla')," +
				 "(3,'Wilaya d Alger')," +
				 "(3,'Wilaya de Bejaia')," +
				 "(3,'Wilaya de Constantine')," +
				 "(3,'al-Aghwat')," +
				 "(3,'al-Bayadh')," +
				 "(3,'al-Jazair')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(3,'al-Wad')," +
				 "(3,'ash-Shalif')," +
				 "(3,'at-Tarif')," +
				 "(4,'Eastern')," +
				 "(4,'Manua')," +
				 "(4,'Swains Island')," +
				 "(4,'Western')," +
				 "(5,'Andorra la Vella')," +
				 "(5,'Canillo')," +
				 "(5,'Encamp')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(5,'La Massana')," +
				 "(5,'Les Escaldes')," +
				 "(5,'Ordino')," +
				 "(5,'Sant Julia de Loria')," +
				 "(6,'Bengo')," +
				 "(6,'Benguela')," +
				 "(6,'Bie')," +
				 "(6,'Cabinda')," +
				 "(6,'Cunene')," +
				 "(6,'Huambo')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(6,'Huila')," +
				 "(6,'Kuando-Kubango')," +
				 "(6,'Kwanza Norte')," +
				 "(6,'Kwanza Sul')," +
				 "(6,'Luanda')," +
				 "(6,'Lunda Norte')," +
				 "(6,'Lunda Sul')," +
				 "(6,'Malanje')," +
				 "(6,'Moxico')," +
				 "(6,'Namibe')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(6,'Uige')," +
				 "(6,'Zaire')," +
				 "(7,'Other Provinces')," +
				 "(8,'Sector claimed by ArgentinaCh')," +
				 "(8,'Sector claimed by ArgentinaUK')," +
				 "(8,'Sector claimed by Australia')," +
				 "(8,'Sector claimed by France')," +
				 "(8,'Sector claimed by New Zealand')," +
				 "(8,'Sector claimed by Norway')," +
				 "(8,'Unclaimed Sector')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(9,'Barbuda')," +
				 "(9,'Saint George')," +
				 "(9,'Saint John')," +
				 "(9,'Saint Mary')," +
				 "(9,'Saint Paul')," +
				 "(9,'Saint Peter')," +
				 "(9,'Saint Philip')," +
				 "(10,'Buenos Aires')," +
				 "(10,'Catamarca')," +
				 "(10,'Chaco')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(10,'Chubut')," +
				 "(10,'Cordoba')," +
				 "(10,'Corrientes')," +
				 "(10,'Distrito Federal')," +
				 "(10,'Entre Rios')," +
				 "(10,'Formosa')," +
				 "(10,'Jujuy')," +
				 "(10,'La Pampa')," +
				 "(10,'La Rioja')," +
				 "(10,'Mendoza')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(10,'Misiones')," +
				 "(10,'Neuquen')," +
				 "(10,'Rio Negro')," +
				 "(10,'Salta')," +
				 "(10,'San Juan')," +
				 "(10,'San Luis')," +
				 "(10,'Santa Cruz')," +
				 "(10,'Santa Fe')," +
				 "(10,'Santiago del Estero')," +
				 "(10,'Tierra del Fuego')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(10,'Tucuman')," +
				 "(11,'Aragatsotn')," +
				 "(11,'Ararat')," +
				 "(11,'Armavir')," +
				 "(11,'Gegharkunik')," +
				 "(11,'Kotaik')," +
				 "(11,'Lori')," +
				 "(11,'Shirak')," +
				 "(11,'Stepanakert')," +
				 "(11,'Syunik')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(11,'Tavush')," +
				 "(11,'Vayots Dzor')," +
				 "(11,'Yerevan')," +
				 "(12,'Aruba')," +
				 "(13,'Auckland')," +
				 "(13,'Australian Capital Territory')," +
				 "(13,'Balgowlah')," +
				 "(13,'Balmain')," +
				 "(13,'Bankstown')," +
				 "(13,'Baulkham Hills')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(13,'Bonnet Bay')," +
				 "(13,'Camberwell')," +
				 "(13,'Carole Park')," +
				 "(13,'Castle Hill')," +
				 "(13,'Caulfield')," +
				 "(13,'Chatswood')," +
				 "(13,'Cheltenham')," +
				 "(13,'Cherrybrook')," +
				 "(13,'Clayton')," +
				 "(13,'Collingwood')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(13,'Frenchs Forest')," +
				 "(13,'Hawthorn')," +
				 "(13,'Jannnali')," +
				 "(13,'Knoxfield')," +
				 "(13,'Melbourne')," +
				 "(13,'New South Wales')," +
				 "(13,'Northern Territory')," +
				 "(13,'Perth')," +
				 "(13,'Queensland')," +
				 "(13,'South Australia')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(13,'Tasmania')," +
				 "(13,'Templestowe')," +
				 "(13,'Victoria')," +
				 "(13,'Werribee south')," +
				 "(13,'Western Australia')," +
				 "(13,'Wheeler')," +
				 "(14,'Bundesland Salzburg')," +
				 "(14,'Bundesland Steiermark')," +
				 "(14,'Bundesland Tirol')," +
				 "(14,'Burgenland')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(14,'Carinthia')," +
				 "(14,'Karnten')," +
				 "(14,'Liezen')," +
				 "(14,'Lower Austria')," +
				 "(14,'Niederosterreich')," +
				 "(14,'Oberosterreich')," +
				 "(14,'Salzburg')," +
				 "(14,'Schleswig-Holstein')," +
				 "(14,'Steiermark')," +
				 "(14,'Styria')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(14,'Tirol')," +
				 "(14,'Upper Austria')," +
				 "(14,'Vorarlberg')," +
				 "(14,'Wien')," +
				 "(15,'Abseron')," +
				 "(15,'Baki Sahari')," +
				 "(15,'Ganca')," +
				 "(15,'Ganja')," +
				 "(15,'Kalbacar')," +
				 "(15,'Lankaran')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(15,'Mil-Qarabax')," +
				 "(15,'Mugan-Salyan')," +
				 "(15,'Nagorni-Qarabax')," +
				 "(15,'Naxcivan')," +
				 "(15,'Priaraks')," +
				 "(15,'Qazax')," +
				 "(15,'Saki')," +
				 "(15,'Sirvan')," +
				 "(15,'Xacmaz')," +
				 "(16,'Abaco')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(16,'Acklins Island')," +
				 "(16,'Andros')," +
				 "(16,'Berry Islands')," +
				 "(16,'Biminis')," +
				 "(16,'Cat Island')," +
				 "(16,'Crooked Island')," +
				 "(16,'Eleuthera')," +
				 "(16,'Exuma and Cays')," +
				 "(16,'Grand Bahama')," +
				 "(16,'Inagua Islands')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(16,'Long Island')," +
				 "(16,'Mayaguana')," +
				 "(16,'New Providence')," +
				 "(16,'Ragged Island')," +
				 "(16,'Rum Cay')," +
				 "(16,'San Salvador')," +
				 "(17,'Isa')," +
				 "(17,'Badiyah')," +
				 "(17,'Hidd')," +
				 "(17,'Jidd Hafs')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(17,'Mahama')," +
				 "(17,'Manama')," +
				 "(17,'Sitrah')," +
				 "(17,'al-Manamah')," +
				 "(17,'al-Muharraq')," +
				 "(17,'ar-Rifaa')," +
				 "(18,'Bagar Hat')," +
				 "(18,'Bandarban')," +
				 "(18,'Barguna')," +
				 "(18,'Barisal')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(18,'Bhola')," +
				 "(18,'Bogora')," +
				 "(18,'Brahman Bariya')," +
				 "(18,'Chandpur')," +
				 "(18,'Chattagam')," +
				 "(18,'Chittagong Division')," +
				 "(18,'Chuadanga')," +
				 "(18,'Dhaka')," +
				 "(18,'Dinajpur')," +
				 "(18,'Faridpur')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(18,'Feni')," +
				 "(18,'Gaybanda')," +
				 "(18,'Gazipur')," +
				 "(18,'Gopalganj')," +
				 "(18,'Habiganj')," +
				 "(18,'Jaipur Hat')," +
				 "(18,'Jamalpur')," +
				 "(18,'Jessor')," +
				 "(18,'Jhalakati')," +
				 "(18,'Jhanaydah')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(18,'Khagrachhari')," +
				 "(18,'Khulna')," +
				 "(18,'Kishorganj')," +
				 "(18,'Koks Bazar')," +
				 "(18,'Komilla')," +
				 "(18,'Kurigram')," +
				 "(18,'Kushtiya')," +
				 "(18,'Lakshmipur')," +
				 "(18,'Lalmanir Hat')," +
				 "(18,'Madaripur')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(18,'Magura')," +
				 "(18,'Maimansingh')," +
				 "(18,'Manikganj')," +
				 "(18,'Maulvi Bazar')," +
				 "(18,'Meherpur')," +
				 "(18,'Munshiganj')," +
				 "(18,'Naral')," +
				 "(18,'Narayanganj')," +
				 "(18,'Narsingdi')," +
				 "(18,'Nator')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(18,'Naugaon')," +
				 "(18,'Nawabganj')," +
				 "(18,'Netrakona')," +
				 "(18,'Nilphamari')," +
				 "(18,'Noakhali')," +
				 "(18,'Pabna')," +
				 "(18,'Panchagarh')," +
				 "(18,'Patuakhali')," +
				 "(18,'Pirojpur')," +
				 "(18,'Rajbari')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(18,'Rajshahi')," +
				 "(18,'Rangamati')," +
				 "(18,'Rangpur')," +
				 "(18,'Satkhira')," +
				 "(18,'Shariatpur')," +
				 "(18,'Sherpur')," +
				 "(18,'Silhat')," +
				 "(18,'Sirajganj')," +
				 "(18,'Sunamganj')," +
				 "(18,'Tangayal')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(18,'Thakurgaon')," +
				 "(19,'Christ Church')," +
				 "(19,'Saint Andrew')," +
				 "(19,'Saint George')," +
				 "(19,'Saint James')," +
				 "(19,'Saint John')," +
				 "(19,'Saint Joseph')," +
				 "(19,'Saint Lucy')," +
				 "(19,'Saint Michael')," +
				 "(19,'Saint Peter')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(19,'Saint Philip')," +
				 "(19,'Saint Thomas')," +
				 "(20,'Brest')," +
				 "(20,'Homjel')," +
				 "(20,'Hrodna')," +
				 "(20,'Mahiljow')," +
				 "(20,'Mahilyowskaya Voblasts')," +
				 "(20,'Minsk')," +
				 "(20,'Minskaja Voblasts')," +
				 "(20,'Petrik')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(20,'Vicebsk')," +
				 "(21,'Antwerpen')," +
				 "(21,'Berchem')," +
				 "(21,'Brabant')," +
				 "(21,'Brabant Wallon')," +
				 "(21,'Brussel')," +
				 "(21,'East Flanders')," +
				 "(21,'Hainaut')," +
				 "(21,'Liege')," +
				 "(21,'Limburg')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(21,'Luxembourg')," +
				 "(21,'Namur')," +
				 "(21,'Ontario')," +
				 "(21,'Oost-Vlaanderen')," +
				 "(21,'Provincie Brabant')," +
				 "(21,'Vlaams-Brabant')," +
				 "(21,'Wallonne')," +
				 "(21,'West-Vlaanderen')," +
				 "(22,'Belize')," +
				 "(22,'Cayo')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(22,'Corozal')," +
				 "(22,'Orange Walk')," +
				 "(22,'Stann Creek')," +
				 "(22,'Toledo')," +
				 "(23,'Alibori')," +
				 "(23,'Atacora')," +
				 "(23,'Atlantique')," +
				 "(23,'Borgou')," +
				 "(23,'Collines')," +
				 "(23,'Couffo')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(23,'Donga')," +
				 "(23,'Littoral')," +
				 "(23,'Mono')," +
				 "(23,'Oueme')," +
				 "(23,'Plateau')," +
				 "(23,'Zou')," +
				 "(24,'Hamilton')," +
				 "(24,'Saint George')," +
				 "(25,'Bumthang')," +
				 "(25,'Chhukha')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(25,'Chirang')," +
				 "(25,'Daga')," +
				 "(25,'Geylegphug')," +
				 "(25,'Ha')," +
				 "(25,'Lhuntshi')," +
				 "(25,'Mongar')," +
				 "(25,'Pemagatsel')," +
				 "(25,'Punakha')," +
				 "(25,'Rinpung')," +
				 "(25,'Samchi')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(25,'Samdrup Jongkhar')," +
				 "(25,'Shemgang')," +
				 "(25,'Tashigang')," +
				 "(25,'Timphu')," +
				 "(25,'Tongsa')," +
				 "(25,'Wangdiphodrang')," +
				 "(26,'Beni')," +
				 "(26,'Chuquisaca')," +
				 "(26,'Cochabamba')," +
				 "(26,'La Paz')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(26,'Oruro')," +
				 "(26,'Pando')," +
				 "(26,'Potosi')," +
				 "(26,'Santa Cruz')," +
				 "(26,'Tarija')," +
				 "(27,'Federacija Bosna i Hercegovina')," +
				 "(27,'Republika Srpska')," +
				 "(28,'Central Bobonong')," +
				 "(28,'Central Boteti')," +
				 "(28,'Central Mahalapye')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(28,'Central Serowe-Palapye')," +
				 "(28,'Central Tutume')," +
				 "(28,'Chobe')," +
				 "(28,'Francistown')," +
				 "(28,'Gaborone')," +
				 "(28,'Ghanzi')," +
				 "(28,'Jwaneng')," +
				 "(28,'Kgalagadi North')," +
				 "(28,'Kgalagadi South')," +
				 "(28,'Kgatleng')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(28,'Kweneng')," +
				 "(28,'Lobatse')," +
				 "(28,'Ngamiland')," +
				 "(28,'Ngwaketse')," +
				 "(28,'North East')," +
				 "(28,'Okavango')," +
				 "(28,'Orapa')," +
				 "(28,'Selibe Phikwe')," +
				 "(28,'South East')," +
				 "(28,'Sowa')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(29,'Bouvet Island')," +
				 "(30,'Acre')," +
				 "(30,'Alagoas')," +
				 "(30,'Amapa')," +
				 "(30,'Amazonas')," +
				 "(30,'Bahia')," +
				 "(30,'Ceara')," +
				 "(30,'Distrito Federal')," +
				 "(30,'Espirito Santo')," +
				 "(30,'Estado de Sao Paulo')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(30,'Goias')," +
				 "(30,'Maranhao')," +
				 "(30,'Mato Grosso')," +
				 "(30,'Mato Grosso do Sul')," +
				 "(30,'Minas Gerais')," +
				 "(30,'Para')," +
				 "(30,'Paraiba')," +
				 "(30,'Parana')," +
				 "(30,'Pernambuco')," +
				 "(30,'Piaui')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(30,'Rio Grande do Norte')," +
				 "(30,'Rio Grande do Sul')," +
				 "(30,'Rio de Janeiro')," +
				 "(30,'Rondonia')," +
				 "(30,'Roraima')," +
				 "(30,'Santa Catarina')," +
				 "(30,'Sao Paulo')," +
				 "(30,'Sergipe')," +
				 "(30,'Tocantins')," +
				 "(31,'British Indian Ocean Territory')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(32,'Belait')," +
				 "(32,'Brunei-Muara')," +
				 "(32,'Temburong')," +
				 "(32,'Tutong')," +
				 "(33,'Blagoevgrad')," +
				 "(33,'Burgas')," +
				 "(33,'Dobrich')," +
				 "(33,'Gabrovo')," +
				 "(33,'Haskovo')," +
				 "(33,'Jambol')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(33,'Kardzhali')," +
				 "(33,'Kjustendil')," +
				 "(33,'Lovech')," +
				 "(33,'Montana')," +
				 "(33,'Oblast Sofiya-Grad')," +
				 "(33,'Pazardzhik')," +
				 "(33,'Pernik')," +
				 "(33,'Pleven')," +
				 "(33,'Plovdiv')," +
				 "(33,'Razgrad')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(33,'Ruse')," +
				 "(33,'Shumen')," +
				 "(33,'Silistra')," +
				 "(33,'Sliven')," +
				 "(33,'Smoljan')," +
				 "(33,'Sofija grad')," +
				 "(33,'Sofijska oblast')," +
				 "(33,'Stara Zagora')," +
				 "(33,'Targovishte')," +
				 "(33,'Varna')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(33,'Veliko Tarnovo')," +
				 "(33,'Vidin')," +
				 "(33,'Vraca')," +
				 "(33,'Yablaniza')," +
				 "(34,'Bale')," +
				 "(34,'Bam')," +
				 "(34,'Bazega')," +
				 "(34,'Bougouriba')," +
				 "(34,'Boulgou')," +
				 "(34,'Boulkiemde')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(34,'Comoe')," +
				 "(34,'Ganzourgou')," +
				 "(34,'Gnagna')," +
				 "(34,'Gourma')," +
				 "(34,'Houet')," +
				 "(34,'Ioba')," +
				 "(34,'Kadiogo')," +
				 "(34,'Kenedougou')," +
				 "(34,'Komandjari')," +
				 "(34,'Kompienga')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(34,'Kossi')," +
				 "(34,'Kouritenga')," +
				 "(34,'Kourweogo')," +
				 "(34,'Leraba')," +
				 "(34,'Mouhoun')," +
				 "(34,'Nahouri')," +
				 "(34,'Namentenga')," +
				 "(34,'Noumbiel')," +
				 "(34,'Oubritenga')," +
				 "(34,'Oudalan')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(34,'Passore')," +
				 "(34,'Poni')," +
				 "(34,'Sanguie')," +
				 "(34,'Sanmatenga')," +
				 "(34,'Seno')," +
				 "(34,'Sissili')," +
				 "(34,'Soum')," +
				 "(34,'Sourou')," +
				 "(34,'Tapoa')," +
				 "(34,'Tuy')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(34,'Yatenga')," +
				 "(34,'Zondoma')," +
				 "(34,'Zoundweogo')," +
				 "(35,'Bubanza')," +
				 "(35,'Bujumbura')," +
				 "(35,'Bururi')," +
				 "(35,'Cankuzo')," +
				 "(35,'Cibitoke')," +
				 "(35,'Gitega')," +
				 "(35,'Karuzi')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(35,'Kayanza')," +
				 "(35,'Kirundo')," +
				 "(35,'Makamba')," +
				 "(35,'Muramvya')," +
				 "(35,'Muyinga')," +
				 "(35,'Ngozi')," +
				 "(35,'Rutana')," +
				 "(35,'Ruyigi')," +
				 "(36,'Banteay Mean Chey')," +
				 "(36,'Bat Dambang')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(36,'Kampong Cham')," +
				 "(36,'Kampong Chhnang')," +
				 "(36,'Kampong Spoeu')," +
				 "(36,'Kampong Thum')," +
				 "(36,'Kampot')," +
				 "(36,'Kandal')," +
				 "(36,'Kaoh Kong')," +
				 "(36,'Kracheh')," +
				 "(36,'Krong Kaeb')," +
				 "(36,'Krong Pailin')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(36,'Krong Preah Sihanouk')," +
				 "(36,'Mondol Kiri')," +
				 "(36,'Otdar Mean Chey')," +
				 "(36,'Phnum Penh')," +
				 "(36,'Pousat')," +
				 "(36,'Preah Vihear')," +
				 "(36,'Prey Veaeng')," +
				 "(36,'Rotanak Kiri')," +
				 "(36,'Siem Reab')," +
				 "(36,'Stueng Traeng')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(36,'Svay Rieng')," +
				 "(36,'Takaev')," +
				 "(37,'Adamaoua')," +
				 "(37,'Centre')," +
				 "(37,'Est')," +
				 "(37,'Littoral')," +
				 "(37,'Nord')," +
				 "(37,'Nord Extreme')," +
				 "(37,'Nordouest')," +
				 "(37,'Ouest')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(37,'Sud')," +
				 "(37,'Sudouest')," +
				 "(38,'Alberta')," +
				 "(38,'British Columbia')," +
				 "(38,'Manitoba')," +
				 "(38,'New Brunswick')," +
				 "(38,'Newfoundland and Labrador')," +
				 "(38,'Northwest Territories')," +
				 "(38,'Nova Scotia')," +
				 "(38,'Nunavut')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(38,'Ontario')," +
				 "(38,'Prince Edward Island')," +
				 "(38,'Quebec')," +
				 "(38,'Saskatchewan')," +
				 "(38,'Yukon')," +
				 "(39,'Boavista')," +
				 "(39,'Brava')," +
				 "(39,'Fogo')," +
				 "(39,'Maio')," +
				 "(39,'Sal')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(39,'Santo Antao')," +
				 "(39,'Sao Nicolau')," +
				 "(39,'Sao Tiago')," +
				 "(39,'Sao Vicente')," +
				 "(40,'Grand Cayman')," +
				 "(41,'Bamingui-Bangoran')," +
				 "(41,'Bangui')," +
				 "(41,'Basse-Kotto')," +
				 "(41,'Haut-Mbomou')," +
				 "(41,'Haute-Kotto')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(41,'Kemo')," +
				 "(41,'Lobaye')," +
				 "(41,'Mambere-Kadei')," +
				 "(41,'Mbomou')," +
				 "(41,'Nana-Gribizi')," +
				 "(41,'Nana-Mambere')," +
				 "(41,'Ombella Mpoko')," +
				 "(41,'Ouaka')," +
				 "(41,'Ouham')," +
				 "(41,'Ouham-Pende')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(41,'Sangha-Mbaere')," +
				 "(41,'Vakaga')," +
				 "(42,'Batha')," +
				 "(42,'Biltine')," +
				 "(42,'Bourkou-Ennedi-Tibesti')," +
				 "(42,'Chari-Baguirmi')," +
				 "(42,'Guera')," +
				 "(42,'Kanem')," +
				 "(42,'Lac')," +
				 "(42,'Logone Occidental')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(42,'Logone Oriental')," +
				 "(42,'Mayo-Kebbi')," +
				 "(42,'Moyen-Chari')," +
				 "(42,'Ouaddai')," +
				 "(42,'Salamat')," +
				 "(42,'Tandjile')," +
				 "(43,'Aisen')," +
				 "(43,'Antofagasta')," +
				 "(43,'Araucania')," +
				 "(43,'Atacama')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(43,'Bio Bio')," +
				 "(43,'Coquimbo')," +
				 "(43,'Libertador General Bernardo O')," +
				 "(43,'Los Lagos')," +
				 "(43,'Magellanes')," +
				 "(43,'Maule')," +
				 "(43,'Metropolitana')," +
				 "(43,'Metropolitana de Santiago')," +
				 "(43,'Tarapaca')," +
				 "(43,'Valparaiso')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(44,'Anhui')," +
				 "(44,'Anhui Province')," +
				 "(44,'Anhui Sheng')," +
				 "(44,'Aomen')," +
				 "(44,'Beijing')," +
				 "(44,'Beijing Shi')," +
				 "(44,'Chongqing')," +
				 "(44,'Fujian')," +
				 "(44,'Fujian Sheng')," +
				 "(44,'Gansu')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(44,'Guangdong')," +
				 "(44,'Guangdong Sheng')," +
				 "(44,'Guangxi')," +
				 "(44,'Guizhou')," +
				 "(44,'Hainan')," +
				 "(44,'Hebei')," +
				 "(44,'Heilongjiang')," +
				 "(44,'Henan')," +
				 "(44,'Hubei')," +
				 "(44,'Hunan')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(44,'Jiangsu')," +
				 "(44,'Jiangsu Sheng')," +
				 "(44,'Jiangxi')," +
				 "(44,'Jilin')," +
				 "(44,'Liaoning')," +
				 "(44,'Liaoning Sheng')," +
				 "(44,'Nei Monggol')," +
				 "(44,'Ningxia Hui')," +
				 "(44,'Qinghai')," +
				 "(44,'Shaanxi')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(44,'Shandong')," +
				 "(44,'Shandong Sheng')," +
				 "(44,'Shanghai')," +
				 "(44,'Shanxi')," +
				 "(44,'Sichuan')," +
				 "(44,'Tianjin')," +
				 "(44,'Xianggang')," +
				 "(44,'Xinjiang')," +
				 "(44,'Xizang')," +
				 "(44,'Yunnan')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(44,'Zhejiang')," +
				 "(44,'Zhejiang Sheng')," +
				 "(45,'Christmas Island')," +
				 "(46,'Cocos Keelin Islands')," +
				 "(47,'Amazonas')," +
				 "(47,'Antioquia')," +
				 "(47,'Arauca')," +
				 "(47,'Atlantico')," +
				 "(47,'Bogota')," +
				 "(47,'Bolivar')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(47,'Boyaca')," +
				 "(47,'Caldas')," +
				 "(47,'Caqueta')," +
				 "(47,'Casanare')," +
				 "(47,'Cauca')," +
				 "(47,'Cesar')," +
				 "(47,'Choco')," +
				 "(47,'Cordoba')," +
				 "(47,'Cundinamarca')," +
				 "(47,'Guainia')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(47,'Guaviare')," +
				 "(47,'Huila')," +
				 "(47,'La Guajira')," +
				 "(47,'Magdalena')," +
				 "(47,'Meta')," +
				 "(47,'Narino')," +
				 "(47,'Norte de Santander')," +
				 "(47,'Putumayo')," +
				 "(47,'Quindio')," +
				 "(47,'Risaralda')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(47,'San Andres y Providencia')," +
				 "(47,'Santander')," +
				 "(47,'Sucre')," +
				 "(47,'Tolima')," +
				 "(47,'Valle del Cauca')," +
				 "(47,'Vaupes')," +
				 "(47,'Vichada')," +
				 "(48,'Mwali')," +
				 "(48,'Njazidja')," +
				 "(48,'Nzwani')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(49,'Bouenza')," +
				 "(49,'Brazzaville')," +
				 "(49,'Cuvette')," +
				 "(49,'Kouilou')," +
				 "(49,'Lekoumou')," +
				 "(49,'Likouala')," +
				 "(49,'Niari')," +
				 "(49,'Plateaux')," +
				 "(49,'Pool')," +
				 "(49,'Sangha')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(50,'Bandundu')," +
				 "(50,'Bas-Congo')," +
				 "(50,'Equateur')," +
				 "(50,'Haut-Congo')," +
				 "(50,'Kasai-Occidental')," +
				 "(50,'Kasai-Oriental')," +
				 "(50,'Katanga')," +
				 "(50,'Kinshasa')," +
				 "(50,'Maniema')," +
				 "(50,'Nord-Kivu')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(50,'Sud-Kivu')," +
				 "(51,'Aitutaki')," +
				 "(51,'Atiu')," +
				 "(51,'Mangaia')," +
				 "(51,'Manihiki')," +
				 "(51,'Mauke')," +
				 "(51,'Mitiaro')," +
				 "(51,'Nassau')," +
				 "(51,'Pukapuka')," +
				 "(51,'Rakahanga')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(51,'Rarotonga')," +
				 "(51,'Tongareva')," +
				 "(52,'Alajuela')," +
				 "(52,'Cartago')," +
				 "(52,'Guanacaste')," +
				 "(52,'Heredia')," +
				 "(52,'Limon')," +
				 "(52,'Puntarenas')," +
				 "(52,'San Jose')," +
				 "(53,'Abidjan')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(53,'Agneby')," +
				 "(53,'Bafing')," +
				 "(53,'Denguele')," +
				 "(53,'Dix-huit Montagnes')," +
				 "(53,'Fromager')," +
				 "(53,'Haut-Sassandra')," +
				 "(53,'Lacs')," +
				 "(53,'Lagunes')," +
				 "(53,'Marahoue')," +
				 "(53,'Moyen-Cavally')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(53,'Moyen-Comoe')," +
				 "(53,'Nzi-Comoe')," +
				 "(53,'Sassandra')," +
				 "(53,'Savanes')," +
				 "(53,'Sud-Bandama')," +
				 "(53,'Sud-Comoe')," +
				 "(53,'Vallee du Bandama')," +
				 "(53,'Worodougou')," +
				 "(53,'Zanzan')," +
				 "(54,'Bjelovar-Bilogora')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(54,'Dubrovnik-Neretva')," +
				 "(54,'Grad Zagreb')," +
				 "(54,'Istra')," +
				 "(54,'Karlovac')," +
				 "(54,'Koprivnica-Krizhevci')," +
				 "(54,'Krapina-Zagorje')," +
				 "(54,'Lika-Senj')," +
				 "(54,'Medhimurje')," +
				 "(54,'Medimurska Zupanija')," +
				 "(54,'Osijek-Baranja')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(54,'Osjecko-Baranjska Zupanija')," +
				 "(54,'Pozhega-Slavonija')," +
				 "(54,'Primorje-Gorski Kotar')," +
				 "(54,'Shibenik-Knin')," +
				 "(54,'Sisak-Moslavina')," +
				 "(54,'Slavonski Brod-Posavina')," +
				 "(54,'Split-Dalmacija')," +
				 "(54,'Varazhdin')," +
				 "(54,'Virovitica-Podravina')," +
				 "(54,'Vukovar-Srijem')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(54,'Zadar')," +
				 "(54,'Zagreb')," +
				 "(55,'Camaguey')," +
				 "(55,'Ciego de Avila')," +
				 "(55,'Cienfuegos')," +
				 "(55,'Ciudad de la Habana')," +
				 "(55,'Granma')," +
				 "(55,'Guantanamo')," +
				 "(55,'Habana')," +
				 "(55,'Holguin')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(55,'Isla de la Juventud')," +
				 "(55,'La Habana')," +
				 "(55,'Las Tunas')," +
				 "(55,'Matanzas')," +
				 "(55,'Pinar del Rio')," +
				 "(55,'Sancti Spiritus')," +
				 "(55,'Santiago de Cuba')," +
				 "(55,'Villa Clara')," +
				 "(56,'Government controlled area')," +
				 "(56,'Limassol')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(56,'Nicosia District')," +
				 "(56,'Paphos')," +
				 "(56,'Turkish controlled area')," +
				 "(57,'Central Bohemian')," +
				 "(57,'Frycovice')," +
				 "(57,'Jihocesky Kraj')," +
				 "(57,'Jihochesky')," +
				 "(57,'Jihomoravsky')," +
				 "(57,'Karlovarsky')," +
				 "(57,'Klecany')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(57,'Kralovehradecky')," +
				 "(57,'Liberecky')," +
				 "(57,'Lipov')," +
				 "(57,'Moravskoslezsky')," +
				 "(57,'Olomoucky')," +
				 "(57,'Olomoucky Kraj')," +
				 "(57,'Pardubicky')," +
				 "(57,'Plzensky')," +
				 "(57,'Praha')," +
				 "(57,'Rajhrad')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(57,'Smirice')," +
				 "(57,'South Moravian')," +
				 "(57,'Straz nad Nisou')," +
				 "(57,'Stredochesky')," +
				 "(57,'Unicov')," +
				 "(57,'Ustecky')," +
				 "(57,'Valletta')," +
				 "(57,'Velesin')," +
				 "(57,'Vysochina')," +
				 "(57,'Zlinsky')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(58,'Arhus')," +
				 "(58,'Bornholm')," +
				 "(58,'Frederiksborg')," +
				 "(58,'Fyn')," +
				 "(58,'Hovedstaden')," +
				 "(58,'Kobenhavn')," +
				 "(58,'Kobenhavns Amt')," +
				 "(58,'Kobenhavns Kommune')," +
				 "(58,'Nordjylland')," +
				 "(58,'Ribe')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(58,'Ringkobing')," +
				 "(58,'Roervig')," +
				 "(58,'Roskilde')," +
				 "(58,'Roslev')," +
				 "(58,'Sjaelland')," +
				 "(58,'Soeborg')," +
				 "(58,'Sonderjylland')," +
				 "(58,'Storstrom')," +
				 "(58,'Syddanmark')," +
				 "(58,'Toelloese')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(58,'Vejle')," +
				 "(58,'Vestsjalland')," +
				 "(58,'Viborg')," +
				 "(59,'Ali Sabih')," +
				 "(59,'Dikhil')," +
				 "(59,'Jibuti')," +
				 "(59,'Tajurah')," +
				 "(59,'Ubuk')," +
				 "(60,'Saint Andrew')," +
				 "(60,'Saint David')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(60,'Saint George')," +
				 "(60,'Saint John')," +
				 "(60,'Saint Joseph')," +
				 "(60,'Saint Luke')," +
				 "(60,'Saint Mark')," +
				 "(60,'Saint Patrick')," +
				 "(60,'Saint Paul')," +
				 "(60,'Saint Peter')," +
				 "(61,'Azua')," +
				 "(61,'Bahoruco')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(61,'Barahona')," +
				 "(61,'Dajabon')," +
				 "(61,'Distrito Nacional')," +
				 "(61,'Duarte')," +
				 "(61,'El Seybo')," +
				 "(61,'Elias Pina')," +
				 "(61,'Espaillat')," +
				 "(61,'Hato Mayor')," +
				 "(61,'Independencia')," +
				 "(61,'La Altagracia')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(61,'La Romana')," +
				 "(61,'La Vega')," +
				 "(61,'Maria Trinidad Sanchez')," +
				 "(61,'Monsenor Nouel')," +
				 "(61,'Monte Cristi')," +
				 "(61,'Monte Plata')," +
				 "(61,'Pedernales')," +
				 "(61,'Peravia')," +
				 "(61,'Puerto Plata')," +
				 "(61,'Salcedo')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(61,'Samana')," +
				 "(61,'San Cristobal')," +
				 "(61,'San Juan')," +
				 "(61,'San Pedro de Macoris')," +
				 "(61,'Sanchez Ramirez')," +
				 "(61,'Santiago')," +
				 "(61,'Santiago Rodriguez')," +
				 "(61,'Valverde')," +
				 "(62,'Aileu')," +
				 "(62,'Ainaro')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(62,'Ambeno')," +
				 "(62,'Baucau')," +
				 "(62,'Bobonaro')," +
				 "(62,'Cova Lima')," +
				 "(62,'Dili')," +
				 "(62,'Ermera')," +
				 "(62,'Lautem')," +
				 "(62,'Liquica')," +
				 "(62,'Manatuto')," +
				 "(62,'Manufahi')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(62,'Viqueque')," +
				 "(63,'Azuay')," +
				 "(63,'Bolivar')," +
				 "(63,'Canar')," +
				 "(63,'Carchi')," +
				 "(63,'Chimborazo')," +
				 "(63,'Cotopaxi')," +
				 "(63,'El Oro')," +
				 "(63,'Esmeraldas')," +
				 "(63,'Galapagos')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(63,'Guayas')," +
				 "(63,'Imbabura')," +
				 "(63,'Loja')," +
				 "(63,'Los Rios')," +
				 "(63,'Manabi')," +
				 "(63,'Morona Santiago')," +
				 "(63,'Napo')," +
				 "(63,'Orellana')," +
				 "(63,'Pastaza')," +
				 "(63,'Pichincha')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(63,'Sucumbios')," +
				 "(63,'Tungurahua')," +
				 "(63,'Zamora Chinchipe')," +
				 "(64,'Aswan')," +
				 "(64,'Asyut')," +
				 "(64,'Bani Suwayf')," +
				 "(64,'Bur Said')," +
				 "(64,'Cairo')," +
				 "(64,'Dumyat')," +
				 "(64,'Kafr-ash-Shaykh')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(64,'Matruh')," +
				 "(64,'Muhafazat ad Daqahliyah')," +
				 "(64,'Muhafazat al Fayyum')," +
				 "(64,'Muhafazat al Gharbiyah')," +
				 "(64,'Muhafazat al Iskandariyah')," +
				 "(64,'Muhafazat al Qahirah')," +
				 "(64,'Qina')," +
				 "(64,'Sawhaj')," +
				 "(64,'Sina al-Janubiyah')," +
				 "(64,'Sina ash-Shamaliyah')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(64,'ad-Daqahliyah')," +
				 "(64,'al-Bahr-al-Ahmar')," +
				 "(64,'al-Buhayrah')," +
				 "(64,'al-Fayyum')," +
				 "(64,'al-Gharbiyah')," +
				 "(64,'al-Iskandariyah')," +
				 "(64,'al-Ismailiyah')," +
				 "(64,'al-Jizah')," +
				 "(64,'al-Minufiyah')," +
				 "(64,'al-Minya')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(64,'al-Qahira')," +
				 "(64,'al-Qalyubiyah')," +
				 "(64,'al-Uqsur')," +
				 "(64,'al-Wadi al-Jadid')," +
				 "(64,'as-Suways')," +
				 "(64,'ash-Sharqiyah')," +
				 "(65,'Ahuachapan')," +
				 "(65,'Cabanas')," +
				 "(65,'Chalatenango')," +
				 "(65,'Cuscatlan')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(65,'La Libertad')," +
				 "(65,'La Paz')," +
				 "(65,'La Union')," +
				 "(65,'Morazan')," +
				 "(65,'San Miguel')," +
				 "(65,'San Salvador')," +
				 "(65,'San Vicente')," +
				 "(65,'Santa Ana')," +
				 "(65,'Sonsonate')," +
				 "(65,'Usulutan')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(66,'Annobon')," +
				 "(66,'Bioko Norte')," +
				 "(66,'Bioko Sur')," +
				 "(66,'Centro Sur')," +
				 "(66,'Kie-Ntem')," +
				 "(66,'Litoral')," +
				 "(66,'Wele-Nzas')," +
				 "(67,'Anseba')," +
				 "(67,'Debub')," +
				 "(67,'Debub-Keih-Bahri')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(67,'Gash-Barka')," +
				 "(67,'Maekel')," +
				 "(67,'Semien-Keih-Bahri')," +
				 "(68,'Harju')," +
				 "(68,'Hiiu')," +
				 "(68,'Ida-Viru')," +
				 "(68,'Jarva')," +
				 "(68,'Jogeva')," +
				 "(68,'Laane')," +
				 "(68,'Laane-Viru')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(68,'Parnu')," +
				 "(68,'Polva')," +
				 "(68,'Rapla')," +
				 "(68,'Saare')," +
				 "(68,'Tartu')," +
				 "(68,'Valga')," +
				 "(68,'Viljandi')," +
				 "(68,'Voru')," +
				 "(69,'Addis Abeba')," +
				 "(69,'Afar')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(69,'Amhara')," +
				 "(69,'Benishangul')," +
				 "(69,'Diredawa')," +
				 "(69,'Gambella')," +
				 "(69,'Harar')," +
				 "(69,'Jigjiga')," +
				 "(69,'Mekele')," +
				 "(69,'Oromia')," +
				 "(69,'Somali')," +
				 "(69,'Southern')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(69,'Tigray')," +
				 "(70,'Christmas Island')," +
				 "(70,'Cocos Islands')," +
				 "(70,'Coral Sea Islands')," +
				 "(71,'Falkland Islands')," +
				 "(71,'South Georgia')," +
				 "(72,'Klaksvik')," +
				 "(72,'Nor ara Eysturoy')," +
				 "(72,'Nor oy')," +
				 "(72,'Sandoy')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(72,'Streymoy')," +
				 "(72,'Su uroy')," +
				 "(72,'Sy ra Eysturoy')," +
				 "(72,'Torshavn')," +
				 "(72,'Vaga')," +
				 "(73,'Central')," +
				 "(73,'Eastern')," +
				 "(73,'Northern')," +
				 "(73,'South Pacific')," +
				 "(73,'Western')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(74,'Ahvenanmaa')," +
				 "(74,'Etela-Karjala')," +
				 "(74,'Etela-Pohjanmaa')," +
				 "(74,'Etela-Savo')," +
				 "(74,'Etela-Suomen Laani')," +
				 "(74,'Ita-Suomen Laani')," +
				 "(74,'Ita-Uusimaa')," +
				 "(74,'Kainuu')," +
				 "(74,'Kanta-Hame')," +
				 "(74,'Keski-Pohjanmaa')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(74,'Keski-Suomi')," +
				 "(74,'Kymenlaakso')," +
				 "(74,'Lansi-Suomen Laani')," +
				 "(74,'Lappi')," +
				 "(74,'Northern Savonia')," +
				 "(74,'Ostrobothnia')," +
				 "(74,'Oulun Laani')," +
				 "(74,'Paijat-Hame')," +
				 "(74,'Pirkanmaa')," +
				 "(74,'Pohjanmaa')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(74,'Pohjois-Karjala')," +
				 "(74,'Pohjois-Pohjanmaa')," +
				 "(74,'Pohjois-Savo')," +
				 "(74,'Saarijarvi')," +
				 "(74,'Satakunta')," +
				 "(74,'Southern Savonia')," +
				 "(74,'Tavastia Proper')," +
				 "(74,'Uleaborgs Lan')," +
				 "(74,'Uusimaa')," +
				 "(74,'Varsinais-Suomi')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(75,'Ain')," +
				 "(75,'Aisne')," +
				 "(75,'Albi Le Sequestre')," +
				 "(75,'Allier')," +
				 "(75,'Alpes-Cote dAzur')," +
				 "(75,'Alpes-Maritimes')," +
				 "(75,'Alpes-de-Haute-Provence')," +
				 "(75,'Alsace')," +
				 "(75,'Aquitaine')," +
				 "(75,'Ardeche')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(75,'Ardennes')," +
				 "(75,'Ariege')," +
				 "(75,'Aube')," +
				 "(75,'Aude')," +
				 "(75,'Auvergne')," +
				 "(75,'Aveyron')," +
				 "(75,'Bas-Rhin')," +
				 "(75,'Basse-Normandie')," +
				 "(75,'Bouches-du-Rhone')," +
				 "(75,'Bourgogne')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(75,'Bretagne')," +
				 "(75,'Brittany')," +
				 "(75,'Burgundy')," +
				 "(75,'Calvados')," +
				 "(75,'Cantal')," +
				 "(75,'Cedex')," +
				 "(75,'Centre')," +
				 "(75,'Charente')," +
				 "(75,'Charente-Maritime')," +
				 "(75,'Cher')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(75,'Correze')," +
				 "(75,'Corse-du-Sud')," +
				 "(75,'Cote-dOr')," +
				 "(75,'Cotes-dArmor')," +
				 "(75,'Creuse')," +
				 "(75,'Crolles')," +
				 "(75,'Deux-Sevres')," +
				 "(75,'Dordogne')," +
				 "(75,'Doubs')," +
				 "(75,'Drome')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(75,'Essonne')," +
				 "(75,'Eure')," +
				 "(75,'Eure-et-Loir')," +
				 "(75,'Feucherolles')," +
				 "(75,'Finistere')," +
				 "(75,'Franche-Comte')," +
				 "(75,'Gard')," +
				 "(75,'Gers')," +
				 "(75,'Gironde')," +
				 "(75,'Haut-Rhin')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(75,'Haute-Corse')," +
				 "(75,'Haute-Garonne')," +
				 "(75,'Haute-Loire')," +
				 "(75,'Haute-Marne')," +
				 "(75,'Haute-Saone')," +
				 "(75,'Haute-Savoie')," +
				 "(75,'Haute-Vienne')," +
				 "(75,'Hautes-Alpes')," +
				 "(75,'Hautes-Pyrenees')," +
				 "(75,'Hauts-de-Seine')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(75,'Herault')," +
				 "(75,'Ile-de-France')," +
				 "(75,'Ille-et-Vilaine')," +
				 "(75,'Indre')," +
				 "(75,'Indre-et-Loire')," +
				 "(75,'Isere')," +
				 "(75,'Jura')," +
				 "(75,'Klagenfurt')," +
				 "(75,'Landes')," +
				 "(75,'Languedoc-Roussillon')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(75,'Larcay')," +
				 "(75,'Le Castellet')," +
				 "(75,'Le Creusot')," +
				 "(75,'Limousin')," +
				 "(75,'Loir-et-Cher')," +
				 "(75,'Loire')," +
				 "(75,'Loire-Atlantique')," +
				 "(75,'Loiret')," +
				 "(75,'Lorraine')," +
				 "(75,'Lot')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(75,'Lot-et-Garonne')," +
				 "(75,'Lower Normandy')," +
				 "(75,'Lozere')," +
				 "(75,'Maine-et-Loire')," +
				 "(75,'Manche')," +
				 "(75,'Marne')," +
				 "(75,'Mayenne')," +
				 "(75,'Meurthe-et-Moselle')," +
				 "(75,'Meuse')," +
				 "(75,'Midi-Pyrenees')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(75,'Morbihan')," +
				 "(75,'Moselle')," +
				 "(75,'Nievre')," +
				 "(75,'Nord')," +
				 "(75,'Nord-Pas-de-Calais')," +
				 "(75,'Oise')," +
				 "(75,'Orne')," +
				 "(75,'Paris')," +
				 "(75,'Pas-de-Calais')," +
				 "(75,'Pays de la Loire')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(75,'Pays-de-la-Loire')," +
				 "(75,'Picardy')," +
				 "(75,'Puy-de-Dome')," +
				 "(75,'Pyrenees-Atlantiques')," +
				 "(75,'Pyrenees-Orientales')," +
				 "(75,'Quelmes')," +
				 "(75,'Rhone')," +
				 "(75,'Rhone-Alpes')," +
				 "(75,'Saint Ouen')," +
				 "(75,'Saint Viatre')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(75,'Saone-et-Loire')," +
				 "(75,'Sarthe')," +
				 "(75,'Savoie')," +
				 "(75,'Seine-Maritime')," +
				 "(75,'Seine-Saint-Denis')," +
				 "(75,'Seine-et-Marne')," +
				 "(75,'Somme')," +
				 "(75,'Sophia Antipolis')," +
				 "(75,'Souvans')," +
				 "(75,'Tarn')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(75,'Tarn-et-Garonne')," +
				 "(75,'Territoire de Belfort')," +
				 "(75,'Treignac')," +
				 "(75,'Upper Normandy')," +
				 "(75,'Val-dOise')," +
				 "(75,'Val-de-Marne')," +
				 "(75,'Var')," +
				 "(75,'Vaucluse')," +
				 "(75,'Vellise')," +
				 "(75,'Vendee')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(75,'Vienne')," +
				 "(75,'Vosges')," +
				 "(75,'Yonne')," +
				 "(75,'Yvelines')," +
				 "(76,'Cayenne')," +
				 "(76,'Saint-Laurent-du-Maroni')," +
				 "(77,'Iles du Vent')," +
				 "(77,'Iles sous le Vent')," +
				 "(77,'Marquesas')," +
				 "(77,'Tuamotu')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(77,'Tubuai')," +
				 "(78,'Amsterdam')," +
				 "(78,'Crozet Islands')," +
				 "(78,'Kerguelen')," +
				 "(79,'Estuaire')," +
				 "(79,'Haut-Ogooue')," +
				 "(79,'Moyen-Ogooue')," +
				 "(79,'Ngounie')," +
				 "(79,'Nyanga')," +
				 "(79,'Ogooue-Ivindo')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(79,'Ogooue-Lolo')," +
				 "(79,'Ogooue-Maritime')," +
				 "(79,'Woleu-Ntem')," +
				 "(80,'Banjul')," +
				 "(80,'Basse')," +
				 "(80,'Brikama')," +
				 "(80,'Janjanbureh')," +
				 "(80,'Kanifing')," +
				 "(80,'Kerewan')," +
				 "(80,'Kuntaur')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(80,'Mansakonko')," +
				 "(81,'Abhasia')," +
				 "(81,'Ajaria')," +
				 "(81,'Guria')," +
				 "(81,'Imereti')," +
				 "(81,'Kaheti')," +
				 "(81,'Kvemo Kartli')," +
				 "(81,'Mcheta-Mtianeti')," +
				 "(81,'Racha')," +
				 "(81,'Samagrelo-Zemo Svaneti')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(81,'Samche-Zhavaheti')," +
				 "(81,'Shida Kartli')," +
				 "(81,'Tbilisi')," +
				 "(82,'Auvergne')," +
				 "(82,'Baden-Wurttemberg')," +
				 "(82,'Bavaria')," +
				 "(82,'Bayern')," +
				 "(82,'Beilstein Wurtt')," +
				 "(82,'Berlin')," +
				 "(82,'Brandenburg')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(82,'Bremen')," +
				 "(82,'Dreisbach')," +
				 "(82,'Freistaat Bayern')," +
				 "(82,'Hamburg')," +
				 "(82,'Hannover')," +
				 "(82,'Heroldstatt')," +
				 "(82,'Hessen')," +
				 "(82,'Kortenberg')," +
				 "(82,'Laasdorf')," +
				 "(82,'Land Baden-Wurttemberg')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(82,'Land Bayern')," +
				 "(82,'Land Brandenburg')," +
				 "(82,'Land Hessen')," +
				 "(82,'Land Mecklenburg-Vorpommern')," +
				 "(82,'Land Nordrhein-Westfalen')," +
				 "(82,'Land Rheinland-Pfalz')," +
				 "(82,'Land Sachsen')," +
				 "(82,'Land Sachsen-Anhalt')," +
				 "(82,'Land Thuringen')," +
				 "(82,'Lower Saxony')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(82,'Mecklenburg-Vorpommern')," +
				 "(82,'Mulfingen')," +
				 "(82,'Munich')," +
				 "(82,'Neubeuern')," +
				 "(82,'Niedersachsen')," +
				 "(82,'Noord-Holland')," +
				 "(82,'Nordrhein-Westfalen')," +
				 "(82,'North Rhine-Westphalia')," +
				 "(82,'Osterode')," +
				 "(82,'Rheinland-Pfalz')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(82,'Rhineland-Palatinate')," +
				 "(82,'Saarland')," +
				 "(82,'Sachsen')," +
				 "(82,'Sachsen-Anhalt')," +
				 "(82,'Saxony')," +
				 "(82,'Schleswig-Holstein')," +
				 "(82,'Thuringia')," +
				 "(82,'Webling')," +
				 "(82,'Weinstrabe')," +
				 "(82,'schlobborn')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(83,'Ashanti')," +
				 "(83,'Brong-Ahafo')," +
				 "(83,'Central')," +
				 "(83,'Eastern')," +
				 "(83,'Greater Accra')," +
				 "(83,'Northern')," +
				 "(83,'Upper East')," +
				 "(83,'Upper West')," +
				 "(83,'Volta')," +
				 "(83,'Western')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(84,'Gibraltar')," +
				 "(85,'Acharnes')," +
				 "(85,'Ahaia')," +
				 "(85,'Aitolia kai Akarnania')," +
				 "(85,'Argolis')," +
				 "(85,'Arkadia')," +
				 "(85,'Arta')," +
				 "(85,'Attica')," +
				 "(85,'Attiki')," +
				 "(85,'Ayion Oros')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(85,'Crete')," +
				 "(85,'Dodekanisos')," +
				 "(85,'Drama')," +
				 "(85,'Evia')," +
				 "(85,'Evritania')," +
				 "(85,'Evros')," +
				 "(85,'Evvoia')," +
				 "(85,'Florina')," +
				 "(85,'Fokis')," +
				 "(85,'Fthiotis')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(85,'Grevena')," +
				 "(85,'Halandri')," +
				 "(85,'Halkidiki')," +
				 "(85,'Hania')," +
				 "(85,'Heraklion')," +
				 "(85,'Hios')," +
				 "(85,'Ilia')," +
				 "(85,'Imathia')," +
				 "(85,'Ioannina')," +
				 "(85,'Iraklion')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(85,'Karditsa')," +
				 "(85,'Kastoria')," +
				 "(85,'Kavala')," +
				 "(85,'Kefallinia')," +
				 "(85,'Kerkira')," +
				 "(85,'Kiklades')," +
				 "(85,'Kilkis')," +
				 "(85,'Korinthia')," +
				 "(85,'Kozani')," +
				 "(85,'Lakonia')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(85,'Larisa')," +
				 "(85,'Lasithi')," +
				 "(85,'Lesvos')," +
				 "(85,'Levkas')," +
				 "(85,'Magnisia')," +
				 "(85,'Messinia')," +
				 "(85,'Nomos Attikis')," +
				 "(85,'Nomos Zakynthou')," +
				 "(85,'Pella')," +
				 "(85,'Pieria')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(85,'Piraios')," +
				 "(85,'Preveza')," +
				 "(85,'Rethimni')," +
				 "(85,'Rodopi')," +
				 "(85,'Samos')," +
				 "(85,'Serrai')," +
				 "(85,'Thesprotia')," +
				 "(85,'Thessaloniki')," +
				 "(85,'Trikala')," +
				 "(85,'Voiotia')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(85,'West Greece')," +
				 "(85,'Xanthi')," +
				 "(85,'Zakinthos')," +
				 "(86,'Aasiaat')," +
				 "(86,'Ammassalik')," +
				 "(86,'Illoqqortoormiut')," +
				 "(86,'Ilulissat')," +
				 "(86,'Ivittuut')," +
				 "(86,'Kangaatsiaq')," +
				 "(86,'Maniitsoq')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(86,'Nanortalik')," +
				 "(86,'Narsaq')," +
				 "(86,'Nuuk')," +
				 "(86,'Paamiut')," +
				 "(86,'Qaanaaq')," +
				 "(86,'Qaqortoq')," +
				 "(86,'Qasigiannguit')," +
				 "(86,'Qeqertarsuaq')," +
				 "(86,'Sisimiut')," +
				 "(86,'Udenfor kommunal inddeling')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(86,'Upernavik')," +
				 "(86,'Uummannaq')," +
				 "(87,'Carriacou-Petite Martinique')," +
				 "(87,'Saint Andrew')," +
				 "(87,'Saint Davids')," +
				 "(87,'Saint Georges')," +
				 "(87,'Saint John')," +
				 "(87,'Saint Mark')," +
				 "(87,'Saint Patrick')," +
				 "(88,'Basse-Terre')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(88,'Grande-Terre')," +
				 "(88,'Iles des Saintes')," +
				 "(88,'La Desirade')," +
				 "(88,'Marie-Galante')," +
				 "(88,'Saint Barthelemy')," +
				 "(88,'Saint Martin')," +
				 "(89,'Agana Heights')," +
				 "(89,'Agat')," +
				 "(89,'Barrigada')," +
				 "(89,'Chalan-Pago-Ordot')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(89,'Dededo')," +
				 "(89,'Hagatna')," +
				 "(89,'Inarajan')," +
				 "(89,'Mangilao')," +
				 "(89,'Merizo')," +
				 "(89,'Mongmong-Toto-Maite')," +
				 "(89,'Santa Rita')," +
				 "(89,'Sinajana')," +
				 "(89,'Talofofo')," +
				 "(89,'Tamuning')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(89,'Yigo')," +
				 "(89,'Yona')," +
				 "(90,'Alta Verapaz')," +
				 "(90,'Baja Verapaz')," +
				 "(90,'Chimaltenango')," +
				 "(90,'Chiquimula')," +
				 "(90,'El Progreso')," +
				 "(90,'Escuintla')," +
				 "(90,'Guatemala')," +
				 "(90,'Huehuetenango')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(90,'Izabal')," +
				 "(90,'Jalapa')," +
				 "(90,'Jutiapa')," +
				 "(90,'Peten')," +
				 "(90,'Quezaltenango')," +
				 "(90,'Quiche')," +
				 "(90,'Retalhuleu')," +
				 "(90,'Sacatepequez')," +
				 "(90,'San Marcos')," +
				 "(90,'Santa Rosa')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(90,'Solola')," +
				 "(90,'Suchitepequez')," +
				 "(90,'Totonicapan')," +
				 "(90,'Zacapa')," +
				 "(91,'Alderney')," +
				 "(91,'Castel')," +
				 "(91,'Forest')," +
				 "(91,'Saint Andrew')," +
				 "(91,'Saint Martin')," +
				 "(91,'Saint Peter Port')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(91,'Saint Pierre du Bois')," +
				 "(91,'Saint Sampson')," +
				 "(91,'Saint Saviour')," +
				 "(91,'Sark')," +
				 "(91,'Torteval')," +
				 "(91,'Vale')," +
				 "(92,'Beyla')," +
				 "(92,'Boffa')," +
				 "(92,'Boke')," +
				 "(92,'Conakry')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(92,'Coyah')," +
				 "(92,'Dabola')," +
				 "(92,'Dalaba')," +
				 "(92,'Dinguiraye')," +
				 "(92,'Faranah')," +
				 "(92,'Forecariah')," +
				 "(92,'Fria')," +
				 "(92,'Gaoual')," +
				 "(92,'Gueckedou')," +
				 "(92,'Kankan')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(92,'Kerouane')," +
				 "(92,'Kindia')," +
				 "(92,'Kissidougou')," +
				 "(92,'Koubia')," +
				 "(92,'Koundara')," +
				 "(92,'Kouroussa')," +
				 "(92,'Labe')," +
				 "(92,'Lola')," +
				 "(92,'Macenta')," +
				 "(92,'Mali')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(92,'Mamou')," +
				 "(92,'Mandiana')," +
				 "(92,'Nzerekore')," +
				 "(92,'Pita')," +
				 "(92,'Siguiri')," +
				 "(92,'Telimele')," +
				 "(92,'Tougue')," +
				 "(92,'Yomou')," +
				 "(93,'Bafata')," +
				 "(93,'Bissau')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(93,'Bolama')," +
				 "(93,'Cacheu')," +
				 "(93,'Gabu')," +
				 "(93,'Oio')," +
				 "(93,'Quinara')," +
				 "(93,'Tombali')," +
				 "(94,'Barima-Waini')," +
				 "(94,'Cuyuni-Mazaruni')," +
				 "(94,'Demerara-Mahaica')," +
				 "(94,'East Berbice-Corentyne')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(94,'Essequibo Islands-West Demerar')," +
				 "(94,'Mahaica-Berbice')," +
				 "(94,'Pomeroon-Supenaam')," +
				 "(94,'Potaro-Siparuni')," +
				 "(94,'Upper Demerara-Berbice')," +
				 "(94,'Upper Takutu-Upper Essequibo')," +
				 "(95,'Artibonite')," +
				 "(95,'Centre')," +
				 "(95,'GrandAnse')," +
				 "(95,'Nord')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(95,'Nord-Est')," +
				 "(95,'Nord-Ouest')," +
				 "(95,'Ouest')," +
				 "(95,'Sud')," +
				 "(95,'Sud-Est')," +
				 "(96,'Heard and McDonald Islands')," +
				 "(97,'Atlantida')," +
				 "(97,'Choluteca')," +
				 "(97,'Colon')," +
				 "(97,'Comayagua')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(97,'Copan')," +
				 "(97,'Cortes')," +
				 "(97,'Distrito Central')," +
				 "(97,'El Paraiso')," +
				 "(97,'Francisco Morazan')," +
				 "(97,'Gracias a Dios')," +
				 "(97,'Intibuca')," +
				 "(97,'Islas de la Bahia')," +
				 "(97,'La Paz')," +
				 "(97,'Lempira')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(97,'Ocotepeque')," +
				 "(97,'Olancho')," +
				 "(97,'Santa Barbara')," +
				 "(97,'Valle')," +
				 "(97,'Yoro')," +
				 "(98,'Hong Kong')," +
				 "(99,'Bacs-Kiskun')," +
				 "(99,'Baranya')," +
				 "(99,'Bekes')," +
				 "(99,'Borsod-Abauj-Zemplen')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(99,'Budapest')," +
				 "(99,'Csongrad')," +
				 "(99,'Fejer')," +
				 "(99,'Gyor-Moson-Sopron')," +
				 "(99,'Hajdu-Bihar')," +
				 "(99,'Heves')," +
				 "(99,'Jasz-Nagykun-Szolnok')," +
				 "(99,'Komarom-Esztergom')," +
				 "(99,'Nograd')," +
				 "(99,'Pest')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(99,'Somogy')," +
				 "(99,'Szabolcs-Szatmar-Bereg')," +
				 "(99,'Tolna')," +
				 "(99,'Vas')," +
				 "(99,'Veszprem')," +
				 "(99,'Zala')," +
				 "(100,'Austurland')," +
				 "(100,'Gullbringusysla')," +
				 "(100,'Hofu borgarsva i')," +
				 "(100,'Nor urland eystra')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(100,'Nor urland vestra')," +
				 "(100,'Su urland')," +
				 "(100,'Su urnes')," +
				 "(100,'Vestfir ir')," +
				 "(100,'Vesturland')," +
				 "(102,'Aceh')," +
				 "(102,'Bali')," +
				 "(102,'Bangka-Belitung')," +
				 "(102,'Banten')," +
				 "(102,'Bengkulu')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(102,'Gandaria')," +
				 "(102,'Gorontalo')," +
				 "(102,'Jakarta')," +
				 "(102,'Jambi')," +
				 "(102,'Jawa Barat')," +
				 "(102,'Jawa Tengah')," +
				 "(102,'Jawa Timur')," +
				 "(102,'Kalimantan Barat')," +
				 "(102,'Kalimantan Selatan')," +
				 "(102,'Kalimantan Tengah')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(102,'Kalimantan Timur')," +
				 "(102,'Kendal')," +
				 "(102,'Lampung')," +
				 "(102,'Maluku')," +
				 "(102,'Maluku Utara')," +
				 "(102,'Nusa Tenggara Barat')," +
				 "(102,'Nusa Tenggara Timur')," +
				 "(102,'Papua')," +
				 "(102,'Riau')," +
				 "(102,'Riau Kepulauan')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(102,'Solo')," +
				 "(102,'Sulawesi Selatan')," +
				 "(102,'Sulawesi Tengah')," +
				 "(102,'Sulawesi Tenggara')," +
				 "(102,'Sulawesi Utara')," +
				 "(102,'Sumatera Barat')," +
				 "(102,'Sumatera Selatan')," +
				 "(102,'Sumatera Utara')," +
				 "(102,'Yogyakarta')," +
				 "(103,'Ardabil')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(103,'Azarbayjan-e Bakhtari')," +
				 "(103,'Azarbayjan-e Khavari')," +
				 "(103,'Bushehr')," +
				 "(103,'Chahar Mahal-e Bakhtiari')," +
				 "(103,'Esfahan')," +
				 "(103,'Fars')," +
				 "(103,'Gilan')," +
				 "(103,'Golestan')," +
				 "(103,'Hamadan')," +
				 "(103,'Hormozgan')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(103,'Ilam')," +
				 "(103,'Kerman')," +
				 "(103,'Kermanshah')," +
				 "(103,'Khorasan')," +
				 "(103,'Khuzestan')," +
				 "(103,'Kohgiluyeh-e Boyerahmad')," +
				 "(103,'Kordestan')," +
				 "(103,'Lorestan')," +
				 "(103,'Markazi')," +
				 "(103,'Mazandaran')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(103,'Ostan-e Esfahan')," +
				 "(103,'Qazvin')," +
				 "(103,'Qom')," +
				 "(103,'Semnan')," +
				 "(103,'Sistan-e Baluchestan')," +
				 "(103,'Tehran')," +
				 "(103,'Yazd')," +
				 "(103,'Zanjan')," +
				 "(104,'Babil')," +
				 "(104,'Baghdad')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(104,'Dahuk')," +
				 "(104,'Dhi Qar')," +
				 "(104,'Diyala')," +
				 "(104,'Erbil')," +
				 "(104,'Irbil')," +
				 "(104,'Karbala')," +
				 "(104,'Kurdistan')," +
				 "(104,'Maysan')," +
				 "(104,'Ninawa')," +
				 "(104,'Salah-ad-Din')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(104,'Wasit')," +
				 "(104,'al-Anbar')," +
				 "(104,'al-Basrah')," +
				 "(104,'al-Muthanna')," +
				 "(104,'al-Qadisiyah')," +
				 "(104,'an-Najaf')," +
				 "(104,'as-Sulaymaniyah')," +
				 "(104,'at-Tamim')," +
				 "(105,'Armagh')," +
				 "(105,'Carlow')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(105,'Cavan')," +
				 "(105,'Clare')," +
				 "(105,'Cork')," +
				 "(105,'Donegal')," +
				 "(105,'Dublin')," +
				 "(105,'Galway')," +
				 "(105,'Kerry')," +
				 "(105,'Kildare')," +
				 "(105,'Kilkenny')," +
				 "(105,'Laois')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(105,'Leinster')," +
				 "(105,'Leitrim')," +
				 "(105,'Limerick')," +
				 "(105,'Loch Garman')," +
				 "(105,'Longford')," +
				 "(105,'Louth')," +
				 "(105,'Mayo')," +
				 "(105,'Meath')," +
				 "(105,'Monaghan')," +
				 "(105,'Offaly')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(105,'Roscommon')," +
				 "(105,'Sligo')," +
				 "(105,'Tipperary North Riding')," +
				 "(105,'Tipperary South Riding')," +
				 "(105,'Ulster')," +
				 "(105,'Waterford')," +
				 "(105,'Westmeath')," +
				 "(105,'Wexford')," +
				 "(105,'Wicklow')," +
				 "(106,'Beit Hanania')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(106,'Ben Gurion Airport')," +
				 "(106,'Bethlehem')," +
				 "(106,'Caesarea')," +
				 "(106,'Centre')," +
				 "(106,'Gaza')," +
				 "(106,'Hadaron')," +
				 "(106,'Haifa District')," +
				 "(106,'Hamerkaz')," +
				 "(106,'Hazafon')," +
				 "(106,'Hebron')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(106,'Jaffa')," +
				 "(106,'Jerusalem')," +
				 "(106,'Khefa')," +
				 "(106,'Kiryat Yam')," +
				 "(106,'Lower Galilee')," +
				 "(106,'Qalqilya')," +
				 "(106,'Talme Elazar')," +
				 "(106,'Tel Aviv')," +
				 "(106,'Tsafon')," +
				 "(106,'Umm El Fahem')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(106,'Yerushalayim')," +
				 "(107,'Abruzzi')," +
				 "(107,'Abruzzo')," +
				 "(107,'Agrigento')," +
				 "(107,'Alessandria')," +
				 "(107,'Ancona')," +
				 "(107,'Arezzo')," +
				 "(107,'Ascoli Piceno')," +
				 "(107,'Asti')," +
				 "(107,'Avellino')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(107,'Bari')," +
				 "(107,'Basilicata')," +
				 "(107,'Belluno')," +
				 "(107,'Benevento')," +
				 "(107,'Bergamo')," +
				 "(107,'Biella')," +
				 "(107,'Bologna')," +
				 "(107,'Bolzano')," +
				 "(107,'Brescia')," +
				 "(107,'Brindisi')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(107,'Calabria')," +
				 "(107,'Campania')," +
				 "(107,'Cartoceto')," +
				 "(107,'Caserta')," +
				 "(107,'Catania')," +
				 "(107,'Chieti')," +
				 "(107,'Como')," +
				 "(107,'Cosenza')," +
				 "(107,'Cremona')," +
				 "(107,'Cuneo')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(107,'Emilia-Romagna')," +
				 "(107,'Ferrara')," +
				 "(107,'Firenze')," +
				 "(107,'Florence')," +
				 "(107,'Forli-Cesena ')," +
				 "(107,'Friuli-Venezia Giulia')," +
				 "(107,'Frosinone')," +
				 "(107,'Genoa')," +
				 "(107,'Gorizia')," +
				 "(107,'LAquila')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(107,'Lazio')," +
				 "(107,'Lecce')," +
				 "(107,'Lecco')," +
				 "(107,'Lecco Province')," +
				 "(107,'Liguria')," +
				 "(107,'Lodi')," +
				 "(107,'Lombardia')," +
				 "(107,'Lombardy')," +
				 "(107,'Macerata')," +
				 "(107,'Mantova')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(107,'Marche')," +
				 "(107,'Messina')," +
				 "(107,'Milan')," +
				 "(107,'Modena')," +
				 "(107,'Molise')," +
				 "(107,'Molteno')," +
				 "(107,'Montenegro')," +
				 "(107,'Monza and Brianza')," +
				 "(107,'Naples')," +
				 "(107,'Novara')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(107,'Padova')," +
				 "(107,'Parma')," +
				 "(107,'Pavia')," +
				 "(107,'Perugia')," +
				 "(107,'Pesaro-Urbino')," +
				 "(107,'Piacenza')," +
				 "(107,'Piedmont')," +
				 "(107,'Piemonte')," +
				 "(107,'Pisa')," +
				 "(107,'Pordenone')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(107,'Potenza')," +
				 "(107,'Puglia')," +
				 "(107,'Reggio Emilia')," +
				 "(107,'Rimini')," +
				 "(107,'Roma')," +
				 "(107,'Salerno')," +
				 "(107,'Sardegna')," +
				 "(107,'Sassari')," +
				 "(107,'Savona')," +
				 "(107,'Sicilia')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(107,'Siena')," +
				 "(107,'Sondrio')," +
				 "(107,'South Tyrol')," +
				 "(107,'Taranto')," +
				 "(107,'Teramo')," +
				 "(107,'Torino')," +
				 "(107,'Toscana')," +
				 "(107,'Trapani')," +
				 "(107,'Trentino-Alto Adige')," +
				 "(107,'Trento')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(107,'Treviso')," +
				 "(107,'Udine')," +
				 "(107,'Umbria')," +
				 "(107,'Valle dAosta')," +
				 "(107,'Varese')," +
				 "(107,'Veneto')," +
				 "(107,'Venezia')," +
				 "(107,'Verbano-Cusio-Ossola')," +
				 "(107,'Vercelli')," +
				 "(107,'Verona')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(107,'Vicenza')," +
				 "(107,'Viterbo')," +
				 "(108,'Buxoro Viloyati')," +
				 "(108,'Clarendon')," +
				 "(108,'Hanover')," +
				 "(108,'Kingston')," +
				 "(108,'Manchester')," +
				 "(108,'Portland')," +
				 "(108,'Saint Andrews')," +
				 "(108,'Saint Ann')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(108,'Saint Catherine')," +
				 "(108,'Saint Elizabeth')," +
				 "(108,'Saint James')," +
				 "(108,'Saint Mary')," +
				 "(108,'Saint Thomas')," +
				 "(108,'Trelawney')," +
				 "(108,'Westmoreland')," +
				 "(109,'Aichi')," +
				 "(109,'Akita')," +
				 "(109,'Aomori')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(109,'Chiba')," +
				 "(109,'Ehime')," +
				 "(109,'Fukui')," +
				 "(109,'Fukuoka')," +
				 "(109,'Fukushima')," +
				 "(109,'Gifu')," +
				 "(109,'Gumma')," +
				 "(109,'Hiroshima')," +
				 "(109,'Hokkaido')," +
				 "(109,'Hyogo')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(109,'Ibaraki')," +
				 "(109,'Ishikawa')," +
				 "(109,'Iwate')," +
				 "(109,'Kagawa')," +
				 "(109,'Kagoshima')," +
				 "(109,'Kanagawa')," +
				 "(109,'Kanto')," +
				 "(109,'Kochi')," +
				 "(109,'Kumamoto')," +
				 "(109,'Kyoto')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(109,'Mie')," +
				 "(109,'Miyagi')," +
				 "(109,'Miyazaki')," +
				 "(109,'Nagano')," +
				 "(109,'Nagasaki')," +
				 "(109,'Nara')," +
				 "(109,'Niigata')," +
				 "(109,'Oita')," +
				 "(109,'Okayama')," +
				 "(109,'Okinawa')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(109,'Osaka')," +
				 "(109,'Saga')," +
				 "(109,'Saitama')," +
				 "(109,'Shiga')," +
				 "(109,'Shimane')," +
				 "(109,'Shizuoka')," +
				 "(109,'Tochigi')," +
				 "(109,'Tokushima')," +
				 "(109,'Tokyo')," +
				 "(109,'Tottori')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(109,'Toyama')," +
				 "(109,'Wakayama')," +
				 "(109,'Yamagata')," +
				 "(109,'Yamaguchi')," +
				 "(109,'Yamanashi')," +
				 "(110,'Grouville')," +
				 "(110,'Saint Brelade')," +
				 "(110,'Saint Clement')," +
				 "(110,'Saint Helier')," +
				 "(110,'Saint John')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(110,'Saint Lawrence')," +
				 "(110,'Saint Martin')," +
				 "(110,'Saint Mary')," +
				 "(110,'Saint Peter')," +
				 "(110,'Saint Saviour')," +
				 "(110,'Trinity')," +
				 "(111,'Ajlun')," +
				 "(111,'Amman')," +
				 "(111,'Irbid')," +
				 "(111,'Jarash')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(111,'Maan')," +
				 "(111,'Madaba')," +
				 "(111,'al-Aqabah')," +
				 "(111,'al-Balqa')," +
				 "(111,'al-Karak')," +
				 "(111,'al-Mafraq')," +
				 "(111,'at-Tafilah')," +
				 "(111,'az-Zarqa')," +
				 "(112,'Akmecet')," +
				 "(112,'Akmola')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(112,'Aktobe')," +
				 "(112,'Almati')," +
				 "(112,'Atirau')," +
				 "(112,'Batis Kazakstan')," +
				 "(112,'Burlinsky Region')," +
				 "(112,'Karagandi')," +
				 "(112,'Kostanay')," +
				 "(112,'Mankistau')," +
				 "(112,'Ontustik Kazakstan')," +
				 "(112,'Pavlodar')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(112,'Sigis Kazakstan')," +
				 "(112,'Soltustik Kazakstan')," +
				 "(112,'Taraz')," +
				 "(113,'Central')," +
				 "(113,'Coast')," +
				 "(113,'Eastern')," +
				 "(113,'Nairobi')," +
				 "(113,'North Eastern')," +
				 "(113,'Nyanza')," +
				 "(113,'Rift Valley')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(113,'Western')," +
				 "(114,'Abaiang')," +
				 "(114,'Abemana')," +
				 "(114,'Aranuka')," +
				 "(114,'Arorae')," +
				 "(114,'Banaba')," +
				 "(114,'Beru')," +
				 "(114,'Butaritari')," +
				 "(114,'Kiritimati')," +
				 "(114,'Kuria')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(114,'Maiana')," +
				 "(114,'Makin')," +
				 "(114,'Marakei')," +
				 "(114,'Nikunau')," +
				 "(114,'Nonouti')," +
				 "(114,'Onotoa')," +
				 "(114,'Phoenix Islands')," +
				 "(114,'Tabiteuea North')," +
				 "(114,'Tabiteuea South')," +
				 "(114,'Tabuaeran')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(114,'Tamana')," +
				 "(114,'Tarawa North')," +
				 "(114,'Tarawa South')," +
				 "(114,'Teraina')," +
				 "(115,'Chagangdo')," +
				 "(115,'Hamgyeongbukto')," +
				 "(115,'Hamgyeongnamdo')," +
				 "(115,'Hwanghaebukto')," +
				 "(115,'Hwanghaenamdo')," +
				 "(115,'Kaeseong')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(115,'Kangweon')," +
				 "(115,'Nampo')," +
				 "(115,'Pyeonganbukto')," +
				 "(115,'Pyeongannamdo')," +
				 "(115,'Pyeongyang')," +
				 "(115,'Yanggang')," +
				 "(116,'Busan')," +
				 "(116,'Cheju')," +
				 "(116,'Chollabuk')," +
				 "(116,'Chollanam')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(116,'Chungbuk')," +
				 "(116,'Chungcheongbuk')," +
				 "(116,'Chungcheongnam')," +
				 "(116,'Chungnam')," +
				 "(116,'Daegu')," +
				 "(116,'Gangwon-do')," +
				 "(116,'Goyang-si')," +
				 "(116,'Gyeonggi-do')," +
				 "(116,'Gyeongsang ')," +
				 "(116,'Gyeongsangnam-do')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(116,'Incheon')," +
				 "(116,'Jeju-Si')," +
				 "(116,'Jeonbuk')," +
				 "(116,'Kangweon')," +
				 "(116,'Kwangju')," +
				 "(116,'Kyeonggi')," +
				 "(116,'Kyeongsangbuk')," +
				 "(116,'Kyeongsangnam')," +
				 "(116,'Kyonggi-do')," +
				 "(116,'Kyungbuk-Do')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(116,'Kyunggi-Do')," +
				 "(116,'Kyunggi-do')," +
				 "(116,'Pusan')," +
				 "(116,'Seoul')," +
				 "(116,'Sudogwon')," +
				 "(116,'Taegu')," +
				 "(116,'Taejeon')," +
				 "(116,'Taejon-gwangyoksi')," +
				 "(116,'Ulsan')," +
				 "(116,'Wonju')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(116,'gwangyoksi')," +
				 "(117,'Al Asimah')," +
				 "(117,'Hawalli')," +
				 "(117,'Mishref')," +
				 "(117,'Qadesiya')," +
				 "(117,'Safat')," +
				 "(117,'Salmiya')," +
				 "(117,'al-Ahmadi')," +
				 "(117,'al-Farwaniyah')," +
				 "(117,'al-Jahra')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(117,'al-Kuwayt')," +
				 "(118,'Batken')," +
				 "(118,'Bishkek')," +
				 "(118,'Chui')," +
				 "(118,'Issyk-Kul')," +
				 "(118,'Jalal-Abad')," +
				 "(118,'Naryn')," +
				 "(118,'Osh')," +
				 "(118,'Talas')," +
				 "(119,'Attopu')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(119,'Bokeo')," +
				 "(119,'Bolikhamsay')," +
				 "(119,'Champasak')," +
				 "(119,'Houaphanh')," +
				 "(119,'Khammouane')," +
				 "(119,'Luang Nam Tha')," +
				 "(119,'Luang Prabang')," +
				 "(119,'Oudomxay')," +
				 "(119,'Phongsaly')," +
				 "(119,'Saravan')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(119,'Savannakhet')," +
				 "(119,'Sekong')," +
				 "(119,'Viangchan Prefecture')," +
				 "(119,'Viangchan Province')," +
				 "(119,'Xaignabury')," +
				 "(119,'Xiang Khuang')," +
				 "(120,'Aizkraukles')," +
				 "(120,'Aluksnes')," +
				 "(120,'Balvu')," +
				 "(120,'Bauskas')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(120,'Cesu')," +
				 "(120,'Daugavpils')," +
				 "(120,'Daugavpils City')," +
				 "(120,'Dobeles')," +
				 "(120,'Gulbenes')," +
				 "(120,'Jekabspils')," +
				 "(120,'Jelgava')," +
				 "(120,'Jelgavas')," +
				 "(120,'Jurmala City')," +
				 "(120,'Kraslavas')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(120,'Kuldigas')," +
				 "(120,'Liepaja')," +
				 "(120,'Liepajas')," +
				 "(120,'Limbazhu')," +
				 "(120,'Ludzas')," +
				 "(120,'Madonas')," +
				 "(120,'Ogres')," +
				 "(120,'Preilu')," +
				 "(120,'Rezekne')," +
				 "(120,'Rezeknes')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(120,'Riga')," +
				 "(120,'Rigas')," +
				 "(120,'Saldus')," +
				 "(120,'Talsu')," +
				 "(120,'Tukuma')," +
				 "(120,'Valkas')," +
				 "(120,'Valmieras')," +
				 "(120,'Ventspils')," +
				 "(120,'Ventspils City')," +
				 "(121,'Beirut')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(121,'Jabal Lubnan')," +
				 "(121,'Mohafazat Liban-Nord')," +
				 "(121,'Mohafazat Mont-Liban')," +
				 "(121,'Sidon')," +
				 "(121,'al-Biqa')," +
				 "(121,'al-Janub')," +
				 "(121,'an-Nabatiyah')," +
				 "(121,'ash-Shamal')," +
				 "(122,'Berea')," +
				 "(122,'Butha-Buthe')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(122,'Leribe')," +
				 "(122,'Mafeteng')," +
				 "(122,'Maseru')," +
				 "(122,'Mohales Hoek')," +
				 "(122,'Mokhotlong')," +
				 "(122,'Qachas Nek')," +
				 "(122,'Quthing')," +
				 "(122,'Thaba-Tseka')," +
				 "(123,'Bomi')," +
				 "(123,'Bong')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(123,'Grand Bassa')," +
				 "(123,'Grand Cape Mount')," +
				 "(123,'Grand Gedeh')," +
				 "(123,'Loffa')," +
				 "(123,'Margibi')," +
				 "(123,'Maryland and Grand Kru')," +
				 "(123,'Montserrado')," +
				 "(123,'Nimba')," +
				 "(123,'Rivercess')," +
				 "(123,'Sinoe')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(124,'Ajdabiya')," +
				 "(124,'Fezzan')," +
				 "(124,'Banghazi')," +
				 "(124,'Darnah')," +
				 "(124,'Ghadamis')," +
				 "(124,'Gharyan')," +
				 "(124,'Misratah')," +
				 "(124,'Murzuq')," +
				 "(124,'Sabha')," +
				 "(124,'Sawfajjin')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(124,'Surt')," +
				 "(124,'Tarabulus')," +
				 "(124,'Tarhunah')," +
				 "(124,'Tripolitania')," +
				 "(124,'Tubruq')," +
				 "(124,'Yafran')," +
				 "(124,'Zlitan')," +
				 "(124,'al-Aziziyah')," +
				 "(124,'al-Fatih')," +
				 "(124,'al-Jabal al Akhdar')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(124,'al-Jufrah')," +
				 "(124,'al-Khums')," +
				 "(124,'al-Kufrah')," +
				 "(124,'an-Nuqat al-Khams')," +
				 "(124,'ash-Shati')," +
				 "(124,'az-Zawiyah')," +
				 "(125,'Balzers')," +
				 "(125,'Eschen')," +
				 "(125,'Gamprin')," +
				 "(125,'Mauren')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(125,'Planken')," +
				 "(125,'Ruggell')," +
				 "(125,'Schaan')," +
				 "(125,'Schellenberg')," +
				 "(125,'Triesen')," +
				 "(125,'Triesenberg')," +
				 "(125,'Vaduz')," +
				 "(126,'Alytaus')," +
				 "(126,'Anyksciai')," +
				 "(126,'Kauno')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(126,'Klaipedos')," +
				 "(126,'Marijampoles')," +
				 "(126,'Panevezhio')," +
				 "(126,'Panevezys')," +
				 "(126,'Shiauliu')," +
				 "(126,'Taurages')," +
				 "(126,'Telshiu')," +
				 "(126,'Telsiai')," +
				 "(126,'Utenos')," +
				 "(126,'Vilniaus')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(127,'Capellen')," +
				 "(127,'Clervaux')," +
				 "(127,'Diekirch')," +
				 "(127,'Echternach')," +
				 "(127,'Esch-sur-Alzette')," +
				 "(127,'Grevenmacher')," +
				 "(127,'Luxembourg')," +
				 "(127,'Mersch')," +
				 "(127,'Redange')," +
				 "(127,'Remich')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(127,'Vianden')," +
				 "(127,'Wiltz')," +
				 "(128,'Macau')," +
				 "(129,'Berovo')," +
				 "(129,'Bitola')," +
				 "(129,'Brod')," +
				 "(129,'Debar')," +
				 "(129,'Delchevo')," +
				 "(129,'Demir Hisar')," +
				 "(129,'Gevgelija')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(129,'Gostivar')," +
				 "(129,'Kavadarci')," +
				 "(129,'Kichevo')," +
				 "(129,'Kochani')," +
				 "(129,'Kratovo')," +
				 "(129,'Kriva Palanka')," +
				 "(129,'Krushevo')," +
				 "(129,'Kumanovo')," +
				 "(129,'Negotino')," +
				 "(129,'Ohrid')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(129,'Prilep')," +
				 "(129,'Probishtip')," +
				 "(129,'Radovish')," +
				 "(129,'Resen')," +
				 "(129,'Shtip')," +
				 "(129,'Skopje')," +
				 "(129,'Struga')," +
				 "(129,'Strumica')," +
				 "(129,'Sveti Nikole')," +
				 "(129,'Tetovo')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(129,'Valandovo')," +
				 "(129,'Veles')," +
				 "(129,'Vinica')," +
				 "(130,'Antananarivo')," +
				 "(130,'Antsiranana')," +
				 "(130,'Fianarantsoa')," +
				 "(130,'Mahajanga')," +
				 "(130,'Toamasina')," +
				 "(130,'Toliary')," +
				 "(131,'Balaka')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(131,'Blantyre City')," +
				 "(131,'Chikwawa')," +
				 "(131,'Chiradzulu')," +
				 "(131,'Chitipa')," +
				 "(131,'Dedza')," +
				 "(131,'Dowa')," +
				 "(131,'Karonga')," +
				 "(131,'Kasungu')," +
				 "(131,'Lilongwe City')," +
				 "(131,'Machinga')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(131,'Mangochi')," +
				 "(131,'Mchinji')," +
				 "(131,'Mulanje')," +
				 "(131,'Mwanza')," +
				 "(131,'Mzimba')," +
				 "(131,'Mzuzu City')," +
				 "(131,'Nkhata Bay')," +
				 "(131,'Nkhotakota')," +
				 "(131,'Nsanje')," +
				 "(131,'Ntcheu')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(131,'Ntchisi')," +
				 "(131,'Phalombe')," +
				 "(131,'Rumphi')," +
				 "(131,'Salima')," +
				 "(131,'Thyolo')," +
				 "(131,'Zomba Municipality')," +
				 "(132,'Johor')," +
				 "(132,'Kedah')," +
				 "(132,'Kelantan')," +
				 "(132,'Kuala Lumpur')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(132,'Labuan')," +
				 "(132,'Melaka')," +
				 "(132,'Negeri Johor')," +
				 "(132,'Negeri Sembilan')," +
				 "(132,'Pahang')," +
				 "(132,'Penang')," +
				 "(132,'Perak')," +
				 "(132,'Perlis')," +
				 "(132,'Pulau Pinang')," +
				 "(132,'Sabah')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(132,'Sarawak')," +
				 "(132,'Selangor')," +
				 "(132,'Sembilan')," +
				 "(132,'Terengganu')," +
				 "(133,'Alif Alif')," +
				 "(133,'Alif Dhaal')," +
				 "(133,'Baa')," +
				 "(133,'Dhaal')," +
				 "(133,'Faaf')," +
				 "(133,'Gaaf Alif')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(133,'Gaaf Dhaal')," +
				 "(133,'Ghaviyani')," +
				 "(133,'Haa Alif')," +
				 "(133,'Haa Dhaal')," +
				 "(133,'Kaaf')," +
				 "(133,'Laam')," +
				 "(133,'Lhaviyani')," +
				 "(133,'Male')," +
				 "(133,'Miim')," +
				 "(133,'Nuun')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(133,'Raa')," +
				 "(133,'Shaviyani')," +
				 "(133,'Siin')," +
				 "(133,'Thaa')," +
				 "(133,'Vaav')," +
				 "(134,'Bamako')," +
				 "(134,'Gao')," +
				 "(134,'Kayes')," +
				 "(134,'Kidal')," +
				 "(134,'Koulikoro')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(134,'Mopti')," +
				 "(134,'Segou')," +
				 "(134,'Sikasso')," +
				 "(134,'Tombouctou')," +
				 "(135,'Gozo and Comino')," +
				 "(135,'Inner Harbour')," +
				 "(135,'Northern')," +
				 "(135,'Outer Harbour')," +
				 "(135,'South Eastern')," +
				 "(135,'Valletta')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(135,'Western')," +
				 "(136,'Castletown')," +
				 "(136,'Douglas')," +
				 "(136,'Laxey')," +
				 "(136,'Onchan')," +
				 "(136,'Peel')," +
				 "(136,'Port Erin')," +
				 "(136,'Port Saint Mary')," +
				 "(136,'Ramsey')," +
				 "(137,'Ailinlaplap')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(137,'Ailuk')," +
				 "(137,'Arno')," +
				 "(137,'Aur')," +
				 "(137,'Bikini')," +
				 "(137,'Ebon')," +
				 "(137,'Enewetak')," +
				 "(137,'Jabat')," +
				 "(137,'Jaluit')," +
				 "(137,'Kili')," +
				 "(137,'Kwajalein')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(137,'Lae')," +
				 "(137,'Lib')," +
				 "(137,'Likiep')," +
				 "(137,'Majuro')," +
				 "(137,'Maloelap')," +
				 "(137,'Mejit')," +
				 "(137,'Mili')," +
				 "(137,'Namorik')," +
				 "(137,'Namu')," +
				 "(137,'Rongelap')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(137,'Ujae')," +
				 "(137,'Utrik')," +
				 "(137,'Wotho')," +
				 "(137,'Wotje')," +
				 "(138,'Fort-de-France')," +
				 "(138,'La Trinite')," +
				 "(138,'Le Marin')," +
				 "(138,'Saint-Pierre')," +
				 "(139,'Adrar')," +
				 "(139,'Assaba')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(139,'Brakna')," +
				 "(139,'Dhakhlat Nawadibu')," +
				 "(139,'Hudh-al-Gharbi')," +
				 "(139,'Hudh-ash-Sharqi')," +
				 "(139,'Inshiri')," +
				 "(139,'Nawakshut')," +
				 "(139,'Qidimagha')," +
				 "(139,'Qurqul')," +
				 "(139,'Taqant')," +
				 "(139,'Tiris Zammur')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(139,'Trarza')," +
				 "(140,'Black River')," +
				 "(140,'Eau Coulee')," +
				 "(140,'Flacq')," +
				 "(140,'Floreal')," +
				 "(140,'Grand Port')," +
				 "(140,'Moka')," +
				 "(140,'Pamplempousses')," +
				 "(140,'Plaines Wilhelm')," +
				 "(140,'Port Louis')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(140,'Riviere du Rempart')," +
				 "(140,'Rodrigues')," +
				 "(140,'Rose Hill')," +
				 "(140,'Savanne')," +
				 "(141,'Mayotte')," +
				 "(141,'Pamanzi')," +
				 "(142,'Aguascalientes')," +
				 "(142,'Baja California')," +
				 "(142,'Baja California Sur')," +
				 "(142,'Campeche')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(142,'Chiapas')," +
				 "(142,'Chihuahua')," +
				 "(142,'Coahuila')," +
				 "(142,'Colima')," +
				 "(142,'Distrito Federal')," +
				 "(142,'Durango')," +
				 "(142,'Estado de Mexico')," +
				 "(142,'Guanajuato')," +
				 "(142,'Guerrero')," +
				 "(142,'Hidalgo')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(142,'Jalisco')," +
				 "(142,'Mexico')," +
				 "(142,'Michoacan')," +
				 "(142,'Morelos')," +
				 "(142,'Nayarit')," +
				 "(142,'Nuevo Leon')," +
				 "(142,'Oaxaca')," +
				 "(142,'Puebla')," +
				 "(142,'Queretaro')," +
				 "(142,'Quintana Roo')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(142,'San Luis Potosi')," +
				 "(142,'Sinaloa')," +
				 "(142,'Sonora')," +
				 "(142,'Tabasco')," +
				 "(142,'Tamaulipas')," +
				 "(142,'Tlaxcala')," +
				 "(142,'Veracruz')," +
				 "(142,'Yucatan')," +
				 "(142,'Zacatecas')," +
				 "(143,'Chuuk')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(143,'Kusaie')," +
				 "(143,'Pohnpei')," +
				 "(143,'Yap')," +
				 "(144,'Balti')," +
				 "(144,'Cahul')," +
				 "(144,'Chisinau')," +
				 "(144,'Chisinau Oras')," +
				 "(144,'Edinet')," +
				 "(144,'Gagauzia')," +
				 "(144,'Lapusna')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(144,'Orhei')," +
				 "(144,'Soroca')," +
				 "(144,'Taraclia')," +
				 "(144,'Tighina')," +
				 "(144,'Transnistria')," +
				 "(144,'Ungheni')," +
				 "(145,'Fontvieille')," +
				 "(145,'La Condamine')," +
				 "(145,'Monaco-Ville')," +
				 "(145,'Monte Carlo')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(146,'Arhangaj')," +
				 "(146,'Bajan-Olgij')," +
				 "(146,'Bajanhongor')," +
				 "(146,'Bulgan')," +
				 "(146,'Darhan-Uul')," +
				 "(146,'Dornod')," +
				 "(146,'Dornogovi')," +
				 "(146,'Dundgovi')," +
				 "(146,'Govi-Altaj')," +
				 "(146,'Govisumber')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(146,'Hentij')," +
				 "(146,'Hovd')," +
				 "(146,'Hovsgol')," +
				 "(146,'Omnogovi')," +
				 "(146,'Orhon')," +
				 "(146,'Ovorhangaj')," +
				 "(146,'Selenge')," +
				 "(146,'Suhbaatar')," +
				 "(146,'Tov')," +
				 "(146,'Ulaanbaatar')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(146,'Uvs')," +
				 "(146,'Zavhan')," +
				 "(147,'Montserrat')," +
				 "(148,'Agadir')," +
				 "(148,'Casablanca')," +
				 "(148,'Chaouia-Ouardigha')," +
				 "(148,'Doukkala-Abda')," +
				 "(148,'Fes-Boulemane')," +
				 "(148,'Gharb-Chrarda-Beni Hssen')," +
				 "(148,'Guelmim')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(148,'Kenitra')," +
				 "(148,'Marrakech-Tensift-Al Haouz')," +
				 "(148,'Meknes-Tafilalet')," +
				 "(148,'Oriental')," +
				 "(148,'Oujda')," +
				 "(148,'Province de Tanger')," +
				 "(148,'Rabat-Sale-Zammour-Zaer')," +
				 "(148,'Sala Al Jadida')," +
				 "(148,'Settat')," +
				 "(148,'Souss Massa-Draa')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(148,'Tadla-Azilal')," +
				 "(148,'Tangier-Tetouan')," +
				 "(148,'Taza-Al Hoceima-Taounate')," +
				 "(148,'Wilaya de Casablanca')," +
				 "(148,'Wilaya de Rabat-Sale')," +
				 "(149,'Cabo Delgado')," +
				 "(149,'Gaza')," +
				 "(149,'Inhambane')," +
				 "(149,'Manica')," +
				 "(149,'Maputo')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(149,'Maputo Provincia')," +
				 "(149,'Nampula')," +
				 "(149,'Niassa')," +
				 "(149,'Sofala')," +
				 "(149,'Tete')," +
				 "(149,'Zambezia')," +
				 "(150,'Ayeyarwady')," +
				 "(150,'Bago')," +
				 "(150,'Chin')," +
				 "(150,'Kachin')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(150,'Kayah')," +
				 "(150,'Kayin')," +
				 "(150,'Magway')," +
				 "(150,'Mandalay')," +
				 "(150,'Mon')," +
				 "(150,'Nay Pyi Taw')," +
				 "(150,'Rakhine')," +
				 "(150,'Sagaing')," +
				 "(150,'Shan')," +
				 "(150,'Tanintharyi')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(150,'Yangon')," +
				 "(151,'Caprivi')," +
				 "(151,'Erongo')," +
				 "(151,'Hardap')," +
				 "(151,'Karas')," +
				 "(151,'Kavango')," +
				 "(151,'Khomas')," +
				 "(151,'Kunene')," +
				 "(151,'Ohangwena')," +
				 "(151,'Omaheke')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(151,'Omusati')," +
				 "(151,'Oshana')," +
				 "(151,'Oshikoto')," +
				 "(151,'Otjozondjupa')," +
				 "(152,'Yaren')," +
				 "(153,'Bagmati')," +
				 "(153,'Bheri')," +
				 "(153,'Dhawalagiri')," +
				 "(153,'Gandaki')," +
				 "(153,'Janakpur')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(153,'Karnali')," +
				 "(153,'Koshi')," +
				 "(153,'Lumbini')," +
				 "(153,'Mahakali')," +
				 "(153,'Mechi')," +
				 "(153,'Narayani')," +
				 "(153,'Rapti')," +
				 "(153,'Sagarmatha')," +
				 "(153,'Seti')," +
				 "(154,'Bonaire')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(154,'Curacao')," +
				 "(154,'Saba')," +
				 "(154,'Sint Eustatius')," +
				 "(154,'Sint Maarten')," +
				 "(155,'Amsterdam')," +
				 "(155,'Benelux')," +
				 "(155,'Drenthe')," +
				 "(155,'Flevoland')," +
				 "(155,'Friesland')," +
				 "(155,'Gelderland')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(155,'Groningen')," +
				 "(155,'Limburg')," +
				 "(155,'Noord-Brabant')," +
				 "(155,'Noord-Holland')," +
				 "(155,'Overijssel')," +
				 "(155,'South Holland')," +
				 "(155,'Utrecht')," +
				 "(155,'Zeeland')," +
				 "(155,'Zuid-Holland')," +
				 "(156,'Iles')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(156,'Nord')," +
				 "(156,'Sud')," +
				 "(157,'Area Outside Region')," +
				 "(157,'Auckland')," +
				 "(157,'Bay of Plenty')," +
				 "(157,'Canterbury')," +
				 "(157,'Christchurch')," +
				 "(157,'Gisborne')," +
				 "(157,'Hawkes Bay')," +
				 "(157,'Manawatu-Wanganui')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(157,'Marlborough')," +
				 "(157,'Nelson')," +
				 "(157,'Northland')," +
				 "(157,'Otago')," +
				 "(157,'Rodney')," +
				 "(157,'Southland')," +
				 "(157,'Taranaki')," +
				 "(157,'Tasman')," +
				 "(157,'Waikato')," +
				 "(157,'Wellington')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(157,'West Coast')," +
				 "(158,'Atlantico Norte')," +
				 "(158,'Atlantico Sur')," +
				 "(158,'Boaco')," +
				 "(158,'Carazo')," +
				 "(158,'Chinandega')," +
				 "(158,'Chontales')," +
				 "(158,'Esteli')," +
				 "(158,'Granada')," +
				 "(158,'Jinotega')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(158,'Leon')," +
				 "(158,'Madriz')," +
				 "(158,'Managua')," +
				 "(158,'Masaya')," +
				 "(158,'Matagalpa')," +
				 "(158,'Nueva Segovia')," +
				 "(158,'Rio San Juan')," +
				 "(158,'Rivas')," +
				 "(159,'Agadez')," +
				 "(159,'Diffa')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(159,'Dosso')," +
				 "(159,'Maradi')," +
				 "(159,'Niamey')," +
				 "(159,'Tahoua')," +
				 "(159,'Tillabery')," +
				 "(159,'Zinder')," +
				 "(160,'Abia')," +
				 "(160,'Abuja Federal Capital Territor')," +
				 "(160,'Adamawa')," +
				 "(160,'Akwa Ibom')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(160,'Anambra')," +
				 "(160,'Bauchi')," +
				 "(160,'Bayelsa')," +
				 "(160,'Benue')," +
				 "(160,'Borno')," +
				 "(160,'Cross River')," +
				 "(160,'Delta')," +
				 "(160,'Ebonyi')," +
				 "(160,'Edo')," +
				 "(160,'Ekiti')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(160,'Enugu')," +
				 "(160,'Gombe')," +
				 "(160,'Imo')," +
				 "(160,'Jigawa')," +
				 "(160,'Kaduna')," +
				 "(160,'Kano')," +
				 "(160,'Katsina')," +
				 "(160,'Kebbi')," +
				 "(160,'Kogi')," +
				 "(160,'Kwara')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(160,'Lagos')," +
				 "(160,'Nassarawa')," +
				 "(160,'Niger')," +
				 "(160,'Ogun')," +
				 "(160,'Ondo')," +
				 "(160,'Osun')," +
				 "(160,'Oyo')," +
				 "(160,'Plateau')," +
				 "(160,'Rivers')," +
				 "(160,'Sokoto')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(160,'Taraba')," +
				 "(160,'Yobe')," +
				 "(160,'Zamfara')," +
				 "(161,'Niue')," +
				 "(162,'Norfolk Island')," +
				 "(163,'Northern Islands')," +
				 "(163,'Rota')," +
				 "(163,'Saipan')," +
				 "(163,'Tinian')," +
				 "(164,'Akershus')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(164,'Aust Agder')," +
				 "(164,'Bergen')," +
				 "(164,'Buskerud')," +
				 "(164,'Finnmark')," +
				 "(164,'Hedmark')," +
				 "(164,'Hordaland')," +
				 "(164,'Moere og Romsdal')," +
				 "(164,'Nord Trondelag')," +
				 "(164,'Nordland')," +
				 "(164,'Oestfold')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(164,'Oppland')," +
				 "(164,'Oslo')," +
				 "(164,'Rogaland')," +
				 "(164,'Soer Troendelag')," +
				 "(164,'Sogn og Fjordane')," +
				 "(164,'Stavern')," +
				 "(164,'Sykkylven')," +
				 "(164,'Telemark')," +
				 "(164,'Troms')," +
				 "(164,'Vest Agder')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(164,'Vestfold')," +
				 "(164,'Ãstfold')," +
				 "(165,'Al Buraimi')," +
				 "(165,'Dhufar')," +
				 "(165,'Masqat')," +
				 "(165,'Musandam')," +
				 "(165,'Rusayl')," +
				 "(165,'Wadi Kabir')," +
				 "(165,'ad-Dakhiliyah')," +
				 "(165,'adh-Dhahirah')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(165,'al-Batinah')," +
				 "(165,'ash-Sharqiyah')," +
				 "(166,'Baluchistan')," +
				 "(166,'Federal Capital Area')," +
				 "(166,'Federally administered Tribal ')," +
				 "(166,'North-West Frontier')," +
				 "(166,'Northern Areas')," +
				 "(166,'Punjab')," +
				 "(166,'Sind')," +
				 "(167,'Aimeliik')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(167,'Airai')," +
				 "(167,'Angaur')," +
				 "(167,'Hatobohei')," +
				 "(167,'Kayangel')," +
				 "(167,'Koror')," +
				 "(167,'Melekeok')," +
				 "(167,'Ngaraard')," +
				 "(167,'Ngardmau')," +
				 "(167,'Ngaremlengui')," +
				 "(167,'Ngatpang')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(167,'Ngchesar')," +
				 "(167,'Ngerchelong')," +
				 "(167,'Ngiwal')," +
				 "(167,'Peleliu')," +
				 "(167,'Sonsorol')," +
				 "(168,'Ariha')," +
				 "(168,'Bayt Lahm')," +
				 "(168,'Bethlehem')," +
				 "(168,'Dayr-al-Balah')," +
				 "(168,'Ghazzah')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(168,'Ghazzah ash-Shamaliyah')," +
				 "(168,'Janin')," +
				 "(168,'Khan Yunis')," +
				 "(168,'Nabulus')," +
				 "(168,'Qalqilyah')," +
				 "(168,'Rafah')," +
				 "(168,'Ram Allah wal-Birah')," +
				 "(168,'Salfit')," +
				 "(168,'Tubas')," +
				 "(168,'Tulkarm')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(168,'al-Khalil')," +
				 "(168,'al-Quds')," +
				 "(169,'Bocas del Toro')," +
				 "(169,'Chiriqui')," +
				 "(169,'Cocle')," +
				 "(169,'Colon')," +
				 "(169,'Darien')," +
				 "(169,'Embera')," +
				 "(169,'Herrera')," +
				 "(169,'Kuna Yala')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(169,'Los Santos')," +
				 "(169,'Ngobe Bugle')," +
				 "(169,'Panama')," +
				 "(169,'Veraguas')," +
				 "(170,'East New Britain')," +
				 "(170,'East Sepik')," +
				 "(170,'Eastern Highlands')," +
				 "(170,'Enga')," +
				 "(170,'Fly River')," +
				 "(170,'Gulf')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(170,'Madang')," +
				 "(170,'Manus')," +
				 "(170,'Milne Bay')," +
				 "(170,'Morobe')," +
				 "(170,'National Capital District')," +
				 "(170,'New Ireland')," +
				 "(170,'North Solomons')," +
				 "(170,'Oro')," +
				 "(170,'Sandaun')," +
				 "(170,'Simbu')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(170,'Southern Highlands')," +
				 "(170,'West New Britain')," +
				 "(170,'Western Highlands')," +
				 "(171,'Alto Paraguay')," +
				 "(171,'Alto Parana')," +
				 "(171,'Amambay')," +
				 "(171,'Asuncion')," +
				 "(171,'Boqueron')," +
				 "(171,'Caaguazu')," +
				 "(171,'Caazapa')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(171,'Canendiyu')," +
				 "(171,'Central')," +
				 "(171,'Concepcion')," +
				 "(171,'Cordillera')," +
				 "(171,'Guaira')," +
				 "(171,'Itapua')," +
				 "(171,'Misiones')," +
				 "(171,'Neembucu')," +
				 "(171,'Paraguari')," +
				 "(171,'Presidente Hayes')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(171,'San Pedro')," +
				 "(172,'Amazonas')," +
				 "(172,'Ancash')," +
				 "(172,'Apurimac')," +
				 "(172,'Arequipa')," +
				 "(172,'Ayacucho')," +
				 "(172,'Cajamarca')," +
				 "(172,'Cusco')," +
				 "(172,'Huancavelica')," +
				 "(172,'Huanuco')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(172,'Ica')," +
				 "(172,'Junin')," +
				 "(172,'La Libertad')," +
				 "(172,'Lambayeque')," +
				 "(172,'Lima y Callao')," +
				 "(172,'Loreto')," +
				 "(172,'Madre de Dios')," +
				 "(172,'Moquegua')," +
				 "(172,'Pasco')," +
				 "(172,'Piura')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(172,'Puno')," +
				 "(172,'San Martin')," +
				 "(172,'Tacna')," +
				 "(172,'Tumbes')," +
				 "(172,'Ucayali')," +
				 "(173,'Batangas')," +
				 "(173,'Bicol')," +
				 "(173,'Bulacan')," +
				 "(173,'Cagayan')," +
				 "(173,'Caraga')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(173,'Central Luzon')," +
				 "(173,'Central Mindanao')," +
				 "(173,'Central Visayas')," +
				 "(173,'Cordillera')," +
				 "(173,'Davao')," +
				 "(173,'Eastern Visayas')," +
				 "(173,'Greater Metropolitan Area')," +
				 "(173,'Ilocos')," +
				 "(173,'Laguna')," +
				 "(173,'Luzon')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(173,'Mactan')," +
				 "(173,'Metropolitan Manila Area')," +
				 "(173,'Muslim Mindanao')," +
				 "(173,'Northern Mindanao')," +
				 "(173,'Southern Mindanao')," +
				 "(173,'Southern Tagalog')," +
				 "(173,'Western Mindanao')," +
				 "(173,'Western Visayas')," +
				 "(174,'Pitcairn Island')," +
				 "(175,'Biale Blota')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(175,'Dobroszyce')," +
				 "(175,'Dolnoslaskie')," +
				 "(175,'Dziekanow Lesny')," +
				 "(175,'Hopowo')," +
				 "(175,'Kartuzy')," +
				 "(175,'Koscian')," +
				 "(175,'Krakow')," +
				 "(175,'Kujawsko-Pomorskie')," +
				 "(175,'Lodzkie')," +
				 "(175,'Lubelskie')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(175,'Lubuskie')," +
				 "(175,'Malomice')," +
				 "(175,'Malopolskie')," +
				 "(175,'Mazowieckie')," +
				 "(175,'Mirkow')," +
				 "(175,'Opolskie')," +
				 "(175,'Ostrowiec')," +
				 "(175,'Podkarpackie')," +
				 "(175,'Podlaskie')," +
				 "(175,'Polska')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(175,'Pomorskie')," +
				 "(175,'Poznan')," +
				 "(175,'Pruszkow')," +
				 "(175,'Rymanowska')," +
				 "(175,'Rzeszow')," +
				 "(175,'Slaskie')," +
				 "(175,'Stare Pole')," +
				 "(175,'Swietokrzyskie')," +
				 "(175,'Warminsko-Mazurskie')," +
				 "(175,'Warsaw')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(175,'Wejherowo')," +
				 "(175,'Wielkopolskie')," +
				 "(175,'Wroclaw')," +
				 "(175,'Zachodnio-Pomorskie')," +
				 "(175,'Zukowo')," +
				 "(176,'Abrantes')," +
				 "(176,'Acores')," +
				 "(176,'Alentejo')," +
				 "(176,'Algarve')," +
				 "(176,'Braga')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(176,'Centro')," +
				 "(176,'Distrito de Leiria')," +
				 "(176,'Distrito de Viana do Castelo')," +
				 "(176,'Distrito de Vila Real')," +
				 "(176,'Distrito do Porto')," +
				 "(176,'Lisboa e Vale do Tejo')," +
				 "(176,'Madeira')," +
				 "(176,'Norte')," +
				 "(176,'Paivas')," +
				 "(177,'Arecibo')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(177,'Bayamon')," +
				 "(177,'Carolina')," +
				 "(177,'Florida')," +
				 "(177,'Guayama')," +
				 "(177,'Humacao')," +
				 "(177,'Mayaguez-Aguadilla')," +
				 "(177,'Ponce')," +
				 "(177,'Salinas')," +
				 "(177,'San Juan')," +
				 "(178,'Doha')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(178,'Jarian-al-Batnah')," +
				 "(178,'Umm Salal')," +
				 "(178,'ad-Dawhah')," +
				 "(178,'al-Ghuwayriyah')," +
				 "(178,'al-Jumayliyah')," +
				 "(178,'al-Khawr')," +
				 "(178,'al-Wakrah')," +
				 "(178,'ar-Rayyan')," +
				 "(178,'ash-Shamal')," +
				 "(179,'Saint-Benoit')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(179,'Saint-Denis')," +
				 "(179,'Saint-Paul')," +
				 "(179,'Saint-Pierre')," +
				 "(180,'Alba')," +
				 "(180,'Arad')," +
				 "(180,'Arges')," +
				 "(180,'Bacau')," +
				 "(180,'Bihor')," +
				 "(180,'Bistrita-Nasaud')," +
				 "(180,'Botosani')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(180,'Braila')," +
				 "(180,'Brasov')," +
				 "(180,'Bucuresti')," +
				 "(180,'Buzau')," +
				 "(180,'Calarasi')," +
				 "(180,'Caras-Severin')," +
				 "(180,'Cluj')," +
				 "(180,'Constanta')," +
				 "(180,'Covasna')," +
				 "(180,'Dambovita')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(180,'Dolj')," +
				 "(180,'Galati')," +
				 "(180,'Giurgiu')," +
				 "(180,'Gorj')," +
				 "(180,'Harghita')," +
				 "(180,'Hunedoara')," +
				 "(180,'Ialomita')," +
				 "(180,'Iasi')," +
				 "(180,'Ilfov')," +
				 "(180,'Maramures')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(180,'Mehedinti')," +
				 "(180,'Mures')," +
				 "(180,'Neamt')," +
				 "(180,'Olt')," +
				 "(180,'Prahova')," +
				 "(180,'Salaj')," +
				 "(180,'Satu Mare')," +
				 "(180,'Sibiu')," +
				 "(180,'Sondelor')," +
				 "(180,'Suceava')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(180,'Teleorman')," +
				 "(180,'Timis')," +
				 "(180,'Tulcea')," +
				 "(180,'Valcea')," +
				 "(180,'Vaslui')," +
				 "(180,'Vrancea')," +
				 "(181,'Adygeja')," +
				 "(181,'Aga')," +
				 "(181,'Alanija')," +
				 "(181,'Altaj')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(181,'Amur')," +
				 "(181,'Arhangelsk')," +
				 "(181,'Astrahan')," +
				 "(181,'Bashkortostan')," +
				 "(181,'Belgorod')," +
				 "(181,'Brjansk')," +
				 "(181,'Burjatija')," +
				 "(181,'Chechenija')," +
				 "(181,'Cheljabinsk')," +
				 "(181,'Chita')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(181,'Chukotka')," +
				 "(181,'Chuvashija')," +
				 "(181,'Dagestan')," +
				 "(181,'Evenkija')," +
				 "(181,'Gorno-Altaj')," +
				 "(181,'Habarovsk')," +
				 "(181,'Hakasija')," +
				 "(181,'Hanty-Mansija')," +
				 "(181,'Ingusetija')," +
				 "(181,'Irkutsk')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(181,'Ivanovo')," +
				 "(181,'Jamalo-Nenets')," +
				 "(181,'Jaroslavl')," +
				 "(181,'Jevrej')," +
				 "(181,'Kabardino-Balkarija')," +
				 "(181,'Kaliningrad')," +
				 "(181,'Kalmykija')," +
				 "(181,'Kaluga')," +
				 "(181,'Kamchatka')," +
				 "(181,'Karachaj-Cherkessija')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(181,'Karelija')," +
				 "(181,'Kemerovo')," +
				 "(181,'Khabarovskiy Kray')," +
				 "(181,'Kirov')," +
				 "(181,'Komi')," +
				 "(181,'Komi-Permjakija')," +
				 "(181,'Korjakija')," +
				 "(181,'Kostroma')," +
				 "(181,'Krasnodar')," +
				 "(181,'Krasnojarsk')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(181,'Krasnoyarskiy Kray')," +
				 "(181,'Kurgan')," +
				 "(181,'Kursk')," +
				 "(181,'Leningrad')," +
				 "(181,'Lipeck')," +
				 "(181,'Magadan')," +
				 "(181,'Marij El')," +
				 "(181,'Mordovija')," +
				 "(181,'Moscow')," +
				 "(181,'Moskovskaja Oblast')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(181,'Moskovskaya Oblast')," +
				 "(181,'Moskva')," +
				 "(181,'Murmansk')," +
				 "(181,'Nenets')," +
				 "(181,'Nizhnij Novgorod')," +
				 "(181,'Novgorod')," +
				 "(181,'Novokusnezk')," +
				 "(181,'Novosibirsk')," +
				 "(181,'Omsk')," +
				 "(181,'Orenburg')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(181,'Orjol')," +
				 "(181,'Penza')," +
				 "(181,'Perm')," +
				 "(181,'Primorje')," +
				 "(181,'Pskov')," +
				 "(181,'Pskovskaya Oblast')," +
				 "(181,'Rjazan')," +
				 "(181,'Rostov')," +
				 "(181,'Saha')," +
				 "(181,'Sahalin')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(181,'Samara')," +
				 "(181,'Samarskaya')," +
				 "(181,'Sankt-Peterburg')," +
				 "(181,'Saratov')," +
				 "(181,'Smolensk')," +
				 "(181,'Stavropol')," +
				 "(181,'Sverdlovsk')," +
				 "(181,'Tajmyrija')," +
				 "(181,'Tambov')," +
				 "(181,'Tatarstan')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(181,'Tjumen')," +
				 "(181,'Tomsk')," +
				 "(181,'Tula')," +
				 "(181,'Tver')," +
				 "(181,'Tyva')," +
				 "(181,'Udmurtija')," +
				 "(181,'Uljanovsk')," +
				 "(181,'Ulyanovskaya Oblast')," +
				 "(181,'Ust-Orda')," +
				 "(181,'Vladimir')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(181,'Volgograd')," +
				 "(181,'Vologda')," +
				 "(181,'Voronezh')," +
				 "(182,'Butare')," +
				 "(182,'Byumba')," +
				 "(182,'Cyangugu')," +
				 "(182,'Gikongoro')," +
				 "(182,'Gisenyi')," +
				 "(182,'Gitarama')," +
				 "(182,'Kibungo')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(182,'Kibuye')," +
				 "(182,'Kigali-ngali')," +
				 "(182,'Ruhengeri')," +
				 "(183,'Ascension')," +
				 "(183,'Gough Island')," +
				 "(183,'Saint Helena')," +
				 "(183,'Tristan da Cunha')," +
				 "(184,'Christ Church Nichola Town')," +
				 "(184,'Saint Anne Sandy Point')," +
				 "(184,'Saint George Basseterre')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(184,'Saint George Gingerland')," +
				 "(184,'Saint James Windward')," +
				 "(184,'Saint John Capesterre')," +
				 "(184,'Saint John Figtree')," +
				 "(184,'Saint Mary Cayon')," +
				 "(184,'Saint Paul Capesterre')," +
				 "(184,'Saint Paul Charlestown')," +
				 "(184,'Saint Peter Basseterre')," +
				 "(184,'Saint Thomas Lowland')," +
				 "(184,'Saint Thomas Middle Island')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(184,'Trinity Palmetto Point')," +
				 "(185,'Anse-la-Raye')," +
				 "(185,'Canaries')," +
				 "(185,'Castries')," +
				 "(185,'Choiseul')," +
				 "(185,'Dennery')," +
				 "(185,'Gros Inlet')," +
				 "(185,'Laborie')," +
				 "(185,'Micoud')," +
				 "(185,'Soufriere')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(185,'Vieux Fort')," +
				 "(186,'Miquelon-Langlade')," +
				 "(186,'Saint-Pierre')," +
				 "(187,'Charlotte')," +
				 "(187,'Grenadines')," +
				 "(187,'Saint Andrew')," +
				 "(187,'Saint David')," +
				 "(187,'Saint George')," +
				 "(187,'Saint Patrick')," +
				 "(188,'Aana')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(188,'Aiga-i-le-Tai')," +
				 "(188,'Atua')," +
				 "(188,'Faasaleleaga')," +
				 "(188,'Gagaemauga')," +
				 "(188,'Gagaifomauga')," +
				 "(188,'Palauli')," +
				 "(188,'Satupaitea')," +
				 "(188,'Tuamasaga')," +
				 "(188,'Vaa-o-Fonoti')," +
				 "(188,'Vaisigano')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(189,'Acquaviva')," +
				 "(189,'Borgo Maggiore')," +
				 "(189,'Chiesanuova')," +
				 "(189,'Domagnano')," +
				 "(189,'Faetano')," +
				 "(189,'Fiorentino')," +
				 "(189,'Montegiardino')," +
				 "(189,'San Marino')," +
				 "(189,'Serravalle')," +
				 "(190,'Agua Grande')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(190,'Cantagalo')," +
				 "(190,'Lemba')," +
				 "(190,'Lobata')," +
				 "(190,'Me-Zochi')," +
				 "(190,'Pague')," +
				 "(191,'Al Khobar')," +
				 "(191,'Aseer')," +
				 "(191,'Ash Sharqiyah')," +
				 "(191,'Asir')," +
				 "(191,'Central Province')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(191,'Eastern Province')," +
				 "(191,'Hail')," +
				 "(191,'Jawf')," +
				 "(191,'Jizan')," +
				 "(191,'Makkah')," +
				 "(191,'Najran')," +
				 "(191,'Qasim')," +
				 "(191,'Tabuk')," +
				 "(191,'Western Province')," +
				 "(191,'al-Bahah')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(191,'al-Hudud-ash-Shamaliyah')," +
				 "(191,'al-Madinah')," +
				 "(191,'ar-Riyad')," +
				 "(192,'Dakar')," +
				 "(192,'Diourbel')," +
				 "(192,'Fatick')," +
				 "(192,'Kaolack')," +
				 "(192,'Kolda')," +
				 "(192,'Louga')," +
				 "(192,'Saint-Louis')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(192,'Tambacounda')," +
				 "(192,'Thies')," +
				 "(192,'Ziguinchor')," +
				 "(193,'Central Serbia')," +
				 "(193,'Kosovo and Metohija')," +
				 "(193,'Vojvodina')," +
				 "(194,'Anse Boileau')," +
				 "(194,'Anse Royale')," +
				 "(194,'Cascade')," +
				 "(194,'Takamaka')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(194,'Victoria')," +
				 "(195,'Eastern')," +
				 "(195,'Northern')," +
				 "(195,'Southern')," +
				 "(195,'Western')," +
				 "(196,'Singapore')," +
				 "(197,'Banskobystricky')," +
				 "(197,'Bratislavsky')," +
				 "(197,'Kosicky')," +
				 "(197,'Nitriansky')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(197,'Presovsky')," +
				 "(197,'Trenciansky')," +
				 "(197,'Trnavsky')," +
				 "(197,'Zilinsky')," +
				 "(198,'Benedikt')," +
				 "(198,'Gorenjska')," +
				 "(198,'Gorishka')," +
				 "(198,'Jugovzhodna Slovenija')," +
				 "(198,'Koroshka')," +
				 "(198,'Notranjsko-krashka')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(198,'Obalno-krashka')," +
				 "(198,'Obcina Domzale')," +
				 "(198,'Obcina Vitanje')," +
				 "(198,'Osrednjeslovenska')," +
				 "(198,'Podravska')," +
				 "(198,'Pomurska')," +
				 "(198,'Savinjska')," +
				 "(198,'Slovenian Littoral')," +
				 "(198,'Spodnjeposavska')," +
				 "(198,'Zasavska')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(199,'Pitcairn')," +
				 "(200,'Central')," +
				 "(200,'Choiseul')," +
				 "(200,'Guadalcanal')," +
				 "(200,'Isabel')," +
				 "(200,'Makira and Ulawa')," +
				 "(200,'Malaita')," +
				 "(200,'Rennell and Bellona')," +
				 "(200,'Temotu')," +
				 "(200,'Western')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(201,'Awdal')," +
				 "(201,'Bakol')," +
				 "(201,'Banadir')," +
				 "(201,'Bari')," +
				 "(201,'Bay')," +
				 "(201,'Galgudug')," +
				 "(201,'Gedo')," +
				 "(201,'Hiran')," +
				 "(201,'Jubbada Hose')," +
				 "(201,'Jubbadha Dexe')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(201,'Mudug')," +
				 "(201,'Nugal')," +
				 "(201,'Sanag')," +
				 "(201,'Shabellaha Dhexe')," +
				 "(201,'Shabellaha Hose')," +
				 "(201,'Togdher')," +
				 "(201,'Woqoyi Galbed')," +
				 "(202,'Eastern Cape')," +
				 "(202,'Free State')," +
				 "(202,'Gauteng')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(202,'Kempton Park')," +
				 "(202,'Kramerville')," +
				 "(202,'KwaZulu Natal')," +
				 "(202,'Limpopo')," +
				 "(202,'Mpumalanga')," +
				 "(202,'North West')," +
				 "(202,'Northern Cape')," +
				 "(202,'Parow')," +
				 "(202,'Table View')," +
				 "(202,'Umtentweni')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(202,'Western Cape')," +
				 "(203,'South Georgia')," +
				 "(204,'Central Equatoria')," +
				 "(205,'A Coruna')," +
				 "(205,'Alacant')," +
				 "(205,'Alava')," +
				 "(205,'Albacete')," +
				 "(205,'Almeria')," +
				 "(205,'Andalucia')," +
				 "(205,'Asturias')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(205,'Avila')," +
				 "(205,'Badajoz')," +
				 "(205,'Balears')," +
				 "(205,'Barcelona')," +
				 "(205,'Bertamirans')," +
				 "(205,'Biscay')," +
				 "(205,'Burgos')," +
				 "(205,'Caceres')," +
				 "(205,'Cadiz')," +
				 "(205,'Cantabria')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(205,'Castello')," +
				 "(205,'Catalunya')," +
				 "(205,'Ceuta')," +
				 "(205,'Ciudad Real')," +
				 "(205,'Comunidad Autonoma de Canarias')," +
				 "(205,'Comunidad Autonoma de Cataluna')," +
				 "(205,'Comunidad Autonoma de Galicia')," +
				 "(205,'Comunidad Autonoma de las Isla')," +
				 "(205,'Comunidad Autonoma del Princip')," +
				 "(205,'Comunidad Valenciana')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(205,'Cordoba')," +
				 "(205,'Cuenca')," +
				 "(205,'Gipuzkoa')," +
				 "(205,'Girona')," +
				 "(205,'Granada')," +
				 "(205,'Guadalajara')," +
				 "(205,'Guipuzcoa')," +
				 "(205,'Huelva')," +
				 "(205,'Huesca')," +
				 "(205,'Jaen')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(205,'La Rioja')," +
				 "(205,'Las Palmas')," +
				 "(205,'Leon')," +
				 "(205,'Lerida')," +
				 "(205,'Lleida')," +
				 "(205,'Lugo')," +
				 "(205,'Madrid')," +
				 "(205,'Malaga')," +
				 "(205,'Melilla')," +
				 "(205,'Murcia')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(205,'Navarra')," +
				 "(205,'Ourense')," +
				 "(205,'Pais Vasco')," +
				 "(205,'Palencia')," +
				 "(205,'Pontevedra')," +
				 "(205,'Salamanca')," +
				 "(205,'Santa Cruz de Tenerife')," +
				 "(205,'Segovia')," +
				 "(205,'Sevilla')," +
				 "(205,'Soria')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(205,'Tarragona')," +
				 "(205,'Tenerife')," +
				 "(205,'Teruel')," +
				 "(205,'Toledo')," +
				 "(205,'Valencia')," +
				 "(205,'Valladolid')," +
				 "(205,'Vizcaya')," +
				 "(205,'Zamora')," +
				 "(205,'Zaragoza')," +
				 "(206,'Amparai')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(206,'Anuradhapuraya')," +
				 "(206,'Badulla')," +
				 "(206,'Boralesgamuwa')," +
				 "(206,'Colombo')," +
				 "(206,'Galla')," +
				 "(206,'Gampaha')," +
				 "(206,'Hambantota')," +
				 "(206,'Kalatura')," +
				 "(206,'Kegalla')," +
				 "(206,'Kilinochchi')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(206,'Kurunegala')," +
				 "(206,'Madakalpuwa')," +
				 "(206,'Maha Nuwara')," +
				 "(206,'Malwana')," +
				 "(206,'Mannarama')," +
				 "(206,'Matale')," +
				 "(206,'Matara')," +
				 "(206,'Monaragala')," +
				 "(206,'Mullaitivu')," +
				 "(206,'North Eastern Province')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(206,'North Western Province')," +
				 "(206,'Nuwara Eliya')," +
				 "(206,'Polonnaruwa')," +
				 "(206,'Puttalama')," +
				 "(206,'Ratnapuraya')," +
				 "(206,'Southern Province')," +
				 "(206,'Tirikunamalaya')," +
				 "(206,'Tuscany')," +
				 "(206,'Vavuniyawa')," +
				 "(206,'Western Province')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(206,'Yapanaya')," +
				 "(206,'kadawatha')," +
				 "(207,'Aali-an-Nil')," +
				 "(207,'Bahr-al-Jabal')," +
				 "(207,'Central Equatoria')," +
				 "(207,'Gharb Bahr-al-Ghazal')," +
				 "(207,'Gharb Darfur')," +
				 "(207,'Gharb Kurdufan')," +
				 "(207,'Gharb-al-Istiwaiyah')," +
				 "(207,'Janub Darfur')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(207,'Janub Kurdufan')," +
				 "(207,'Junqali')," +
				 "(207,'Kassala')," +
				 "(207,'Nahr-an-Nil')," +
				 "(207,'Shamal Bahr-al-Ghazal')," +
				 "(207,'Shamal Darfur')," +
				 "(207,'Shamal Kurdufan')," +
				 "(207,'Sharq-al-Istiwaiyah')," +
				 "(207,'Sinnar')," +
				 "(207,'Warab')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(207,'Wilayat al Khartum')," +
				 "(207,'al-Bahr-al-Ahmar')," +
				 "(207,'al-Buhayrat')," +
				 "(207,'al-Jazirah')," +
				 "(207,'al-Khartum')," +
				 "(207,'al-Qadarif')," +
				 "(207,'al-Wahdah')," +
				 "(207,'an-Nil-al-Abyad')," +
				 "(207,'an-Nil-al-Azraq')," +
				 "(207,'ash-Shamaliyah')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(208,'Brokopondo')," +
				 "(208,'Commewijne')," +
				 "(208,'Coronie')," +
				 "(208,'Marowijne')," +
				 "(208,'Nickerie')," +
				 "(208,'Para')," +
				 "(208,'Paramaribo')," +
				 "(208,'Saramacca')," +
				 "(208,'Wanica')," +
				 "(209,'Svalbard')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(210,'Hhohho')," +
				 "(210,'Lubombo')," +
				 "(210,'Manzini')," +
				 "(210,'Shiselweni')," +
				 "(211,'Alvsborgs Lan')," +
				 "(211,'Angermanland')," +
				 "(211,'Blekinge')," +
				 "(211,'Bohuslan')," +
				 "(211,'Dalarna')," +
				 "(211,'Gavleborg')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(211,'Gaza')," +
				 "(211,'Gotland')," +
				 "(211,'Halland')," +
				 "(211,'Jamtland')," +
				 "(211,'Jonkoping')," +
				 "(211,'Kalmar')," +
				 "(211,'Kristianstads')," +
				 "(211,'Kronoberg')," +
				 "(211,'Norrbotten')," +
				 "(211,'Orebro')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(211,'Ostergotland')," +
				 "(211,'Saltsjo-Boo')," +
				 "(211,'Skane')," +
				 "(211,'Smaland')," +
				 "(211,'Sodermanland')," +
				 "(211,'Stockholm')," +
				 "(211,'Uppsala')," +
				 "(211,'Varmland')," +
				 "(211,'Vasterbotten')," +
				 "(211,'Vastergotland')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(211,'Vasternorrland')," +
				 "(211,'Vastmanland')," +
				 "(211,'Vastra Gotaland')," +
				 "(212,'Aargau')," +
				 "(212,'Appenzell Inner-Rhoden')," +
				 "(212,'Appenzell-Ausser Rhoden')," +
				 "(212,'Basel-Landschaft')," +
				 "(212,'Basel-Stadt')," +
				 "(212,'Bern')," +
				 "(212,'Canton Ticino')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(212,'Fribourg')," +
				 "(212,'Geneve')," +
				 "(212,'Glarus')," +
				 "(212,'Graubunden')," +
				 "(212,'Heerbrugg')," +
				 "(212,'Jura')," +
				 "(212,'Kanton Aargau')," +
				 "(212,'Luzern')," +
				 "(212,'Morbio Inferiore')," +
				 "(212,'Muhen')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(212,'Neuchatel')," +
				 "(212,'Nidwalden')," +
				 "(212,'Obwalden')," +
				 "(212,'Sankt Gallen')," +
				 "(212,'Schaffhausen')," +
				 "(212,'Schwyz')," +
				 "(212,'Solothurn')," +
				 "(212,'Thurgau')," +
				 "(212,'Ticino')," +
				 "(212,'Uri')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(212,'Valais')," +
				 "(212,'Vaud')," +
				 "(212,'Vauffelin')," +
				 "(212,'Zug')," +
				 "(212,'Zurich')," +
				 "(213,'Aleppo')," +
				 "(213,'Dara')," +
				 "(213,'Dayr-az-Zawr')," +
				 "(213,'Dimashq')," +
				 "(213,'Halab')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(213,'Hamah')," +
				 "(213,'Hims')," +
				 "(213,'Idlib')," +
				 "(213,'Madinat Dimashq')," +
				 "(213,'Tartus')," +
				 "(213,'al-Hasakah')," +
				 "(213,'al-Ladhiqiyah')," +
				 "(213,'al-Qunaytirah')," +
				 "(213,'ar-Raqqah')," +
				 "(213,'as-Suwayda')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(214,'Changhwa')," +
				 "(214,'Chiayi Hsien')," +
				 "(214,'Chiayi Shih')," +
				 "(214,'Eastern Taipei')," +
				 "(214,'Hsinchu Hsien')," +
				 "(214,'Hsinchu Shih')," +
				 "(214,'Hualien')," +
				 "(214,'Ilan')," +
				 "(214,'Kaohsiung Hsien')," +
				 "(214,'Kaohsiung Shih')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(214,'Keelung Shih')," +
				 "(214,'Kinmen')," +
				 "(214,'Miaoli')," +
				 "(214,'Nantou')," +
				 "(214,'Northern Taiwan')," +
				 "(214,'Penghu')," +
				 "(214,'Pingtung')," +
				 "(214,'Taichung')," +
				 "(214,'Taichung Hsien')," +
				 "(214,'Taichung Shih')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(214,'Tainan Hsien')," +
				 "(214,'Tainan Shih')," +
				 "(214,'Taipei Hsien')," +
				 "(214,'Taipei Shih  Taipei Hsien')," +
				 "(214,'Taitung')," +
				 "(214,'Taoyuan')," +
				 "(214,'Yilan')," +
				 "(214,'Yun-Lin Hsien')," +
				 "(214,'Yunlin')," +
				 "(215,'Dushanbe')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(215,'Gorno-Badakhshan')," +
				 "(215,'Karotegin')," +
				 "(215,'Khatlon')," +
				 "(215,'Sughd')," +
				 "(216,'Arusha')," +
				 "(216,'Dar es Salaam')," +
				 "(216,'Dodoma')," +
				 "(216,'Iringa')," +
				 "(216,'Kagera')," +
				 "(216,'Kigoma')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(216,'Kilimanjaro')," +
				 "(216,'Lindi')," +
				 "(216,'Mara')," +
				 "(216,'Mbeya')," +
				 "(216,'Morogoro')," +
				 "(216,'Mtwara')," +
				 "(216,'Mwanza')," +
				 "(216,'Pwani')," +
				 "(216,'Rukwa')," +
				 "(216,'Ruvuma')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(216,'Shinyanga')," +
				 "(216,'Singida')," +
				 "(216,'Tabora')," +
				 "(216,'Tanga')," +
				 "(216,'Zanzibar and Pemba')," +
				 "(217,'Amnat Charoen')," +
				 "(217,'Ang Thong')," +
				 "(217,'Bangkok')," +
				 "(217,'Buri Ram')," +
				 "(217,'Chachoengsao')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(217,'Chai Nat')," +
				 "(217,'Chaiyaphum')," +
				 "(217,'Changwat Chaiyaphum')," +
				 "(217,'Chanthaburi')," +
				 "(217,'Chiang Mai')," +
				 "(217,'Chiang Rai')," +
				 "(217,'Chon Buri')," +
				 "(217,'Chumphon')," +
				 "(217,'Kalasin')," +
				 "(217,'Kamphaeng Phet')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(217,'Kanchanaburi')," +
				 "(217,'Khon Kaen')," +
				 "(217,'Krabi')," +
				 "(217,'Krung Thep')," +
				 "(217,'Lampang')," +
				 "(217,'Lamphun')," +
				 "(217,'Loei')," +
				 "(217,'Lop Buri')," +
				 "(217,'Mae Hong Son')," +
				 "(217,'Maha Sarakham')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(217,'Mukdahan')," +
				 "(217,'Nakhon Nayok')," +
				 "(217,'Nakhon Pathom')," +
				 "(217,'Nakhon Phanom')," +
				 "(217,'Nakhon Ratchasima')," +
				 "(217,'Nakhon Sawan')," +
				 "(217,'Nakhon Si Thammarat')," +
				 "(217,'Nan')," +
				 "(217,'Narathiwat')," +
				 "(217,'Nong Bua Lam Phu')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(217,'Nong Khai')," +
				 "(217,'Nonthaburi')," +
				 "(217,'Pathum Thani')," +
				 "(217,'Pattani')," +
				 "(217,'Phangnga')," +
				 "(217,'Phatthalung')," +
				 "(217,'Phayao')," +
				 "(217,'Phetchabun')," +
				 "(217,'Phetchaburi')," +
				 "(217,'Phichit')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(217,'Phitsanulok')," +
				 "(217,'Phra Nakhon Si Ayutthaya')," +
				 "(217,'Phrae')," +
				 "(217,'Phuket')," +
				 "(217,'Prachin Buri')," +
				 "(217,'Prachuap Khiri Khan')," +
				 "(217,'Ranong')," +
				 "(217,'Ratchaburi')," +
				 "(217,'Rayong')," +
				 "(217,'Roi Et')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(217,'Sa Kaeo')," +
				 "(217,'Sakon Nakhon')," +
				 "(217,'Samut Prakan')," +
				 "(217,'Samut Sakhon')," +
				 "(217,'Samut Songkhran')," +
				 "(217,'Saraburi')," +
				 "(217,'Satun')," +
				 "(217,'Si Sa Ket')," +
				 "(217,'Sing Buri')," +
				 "(217,'Songkhla')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(217,'Sukhothai')," +
				 "(217,'Suphan Buri')," +
				 "(217,'Surat Thani')," +
				 "(217,'Surin')," +
				 "(217,'Tak')," +
				 "(217,'Trang')," +
				 "(217,'Trat')," +
				 "(217,'Ubon Ratchathani')," +
				 "(217,'Udon Thani')," +
				 "(217,'Uthai Thani')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(217,'Uttaradit')," +
				 "(217,'Yala')," +
				 "(217,'Yasothon')," +
				 "(218,'Centre')," +
				 "(218,'Kara')," +
				 "(218,'Maritime')," +
				 "(218,'Plateaux')," +
				 "(218,'Savanes')," +
				 "(219,'Atafu')," +
				 "(219,'Fakaofo')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(219,'Nukunonu')," +
				 "(220,'Eua')," +
				 "(220,'Haapai')," +
				 "(220,'Niuas')," +
				 "(220,'Tongatapu')," +
				 "(220,'Vavau')," +
				 "(221,'Arima-Tunapuna-Piarco')," +
				 "(221,'Caroni')," +
				 "(221,'Chaguanas')," +
				 "(221,'Couva-Tabaquite-Talparo')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(221,'Diego Martin')," +
				 "(221,'Glencoe')," +
				 "(221,'Penal Debe')," +
				 "(221,'Point Fortin')," +
				 "(221,'Port of Spain')," +
				 "(221,'Princes Town')," +
				 "(221,'Saint George')," +
				 "(221,'San Fernando')," +
				 "(221,'San Juan')," +
				 "(221,'Sangre Grande')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(221,'Siparia')," +
				 "(221,'Tobago')," +
				 "(222,'Aryanah')," +
				 "(222,'Bajah')," +
				 "(222,'Bin Arus')," +
				 "(222,'Binzart')," +
				 "(222,'Gouvernorat de Ariana')," +
				 "(222,'Gouvernorat de Nabeul')," +
				 "(222,'Gouvernorat de Sousse')," +
				 "(222,'Hammamet Yasmine')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(222,'Jundubah')," +
				 "(222,'Madaniyin')," +
				 "(222,'Manubah')," +
				 "(222,'Monastir')," +
				 "(222,'Nabul')," +
				 "(222,'Qabis')," +
				 "(222,'Qafsah')," +
				 "(222,'Qibili')," +
				 "(222,'Safaqis')," +
				 "(222,'Sfax')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(222,'Sidi Bu Zayd')," +
				 "(222,'Silyanah')," +
				 "(222,'Susah')," +
				 "(222,'Tatawin')," +
				 "(222,'Tawzar')," +
				 "(222,'Tunis')," +
				 "(222,'Zaghwan')," +
				 "(222,'al-Kaf')," +
				 "(222,'al-Mahdiyah')," +
				 "(222,'al-Munastir')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(222,'al-Qasrayn')," +
				 "(222,'al-Qayrawan')," +
				 "(223,'Adana')," +
				 "(223,'Adiyaman')," +
				 "(223,'Afyon')," +
				 "(223,'Agri')," +
				 "(223,'Aksaray')," +
				 "(223,'Amasya')," +
				 "(223,'Ankara')," +
				 "(223,'Antalya')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(223,'Ardahan')," +
				 "(223,'Artvin')," +
				 "(223,'Aydin')," +
				 "(223,'Balikesir')," +
				 "(223,'Bartin')," +
				 "(223,'Batman')," +
				 "(223,'Bayburt')," +
				 "(223,'Bilecik')," +
				 "(223,'Bingol')," +
				 "(223,'Bitlis')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(223,'Bolu')," +
				 "(223,'Burdur')," +
				 "(223,'Bursa')," +
				 "(223,'Canakkale')," +
				 "(223,'Cankiri')," +
				 "(223,'Corum')," +
				 "(223,'Denizli')," +
				 "(223,'Diyarbakir')," +
				 "(223,'Duzce')," +
				 "(223,'Edirne')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(223,'Elazig')," +
				 "(223,'Erzincan')," +
				 "(223,'Erzurum')," +
				 "(223,'Eskisehir')," +
				 "(223,'Gaziantep')," +
				 "(223,'Giresun')," +
				 "(223,'Gumushane')," +
				 "(223,'Hakkari')," +
				 "(223,'Hatay')," +
				 "(223,'Icel')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(223,'Igdir')," +
				 "(223,'Isparta')," +
				 "(223,'Istanbul')," +
				 "(223,'Izmir')," +
				 "(223,'Kahramanmaras')," +
				 "(223,'Karabuk')," +
				 "(223,'Karaman')," +
				 "(223,'Kars')," +
				 "(223,'Karsiyaka')," +
				 "(223,'Kastamonu')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(223,'Kayseri')," +
				 "(223,'Kilis')," +
				 "(223,'Kirikkale')," +
				 "(223,'Kirklareli')," +
				 "(223,'Kirsehir')," +
				 "(223,'Kocaeli')," +
				 "(223,'Konya')," +
				 "(223,'Kutahya')," +
				 "(223,'Lefkosa')," +
				 "(223,'Malatya')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(223,'Manisa')," +
				 "(223,'Mardin')," +
				 "(223,'Mugla')," +
				 "(223,'Mus')," +
				 "(223,'Nevsehir')," +
				 "(223,'Nigde')," +
				 "(223,'Ordu')," +
				 "(223,'Osmaniye')," +
				 "(223,'Rize')," +
				 "(223,'Sakarya')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(223,'Samsun')," +
				 "(223,'Sanliurfa')," +
				 "(223,'Siirt')," +
				 "(223,'Sinop')," +
				 "(223,'Sirnak')," +
				 "(223,'Sivas')," +
				 "(223,'Tekirdag')," +
				 "(223,'Tokat')," +
				 "(223,'Trabzon')," +
				 "(223,'Tunceli')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(223,'Usak')," +
				 "(223,'Van')," +
				 "(223,'Yalova')," +
				 "(223,'Yozgat')," +
				 "(223,'Zonguldak')," +
				 "(224,'Ahal')," +
				 "(224,'Asgabat')," +
				 "(224,'Balkan')," +
				 "(224,'Dasoguz')," +
				 "(224,'Lebap')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(224,'Mari')," +
				 "(225,'Grand Turk')," +
				 "(225,'South Caicos and East Caicos')," +
				 "(226,'Funafuti')," +
				 "(226,'Nanumanga')," +
				 "(226,'Nanumea')," +
				 "(226,'Niutao')," +
				 "(226,'Nui')," +
				 "(226,'Nukufetau')," +
				 "(226,'Nukulaelae')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(226,'Vaitupu')," +
				 "(227,'Central')," +
				 "(227,'Eastern')," +
				 "(227,'Northern')," +
				 "(227,'Western')," +
				 "(228,'Cherkaska')," +
				 "(228,'Chernihivska')," +
				 "(228,'Chernivetska')," +
				 "(228,'Crimea')," +
				 "(228,'Dnipropetrovska')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(228,'Donetska')," +
				 "(228,'Ivano-Frankivska')," +
				 "(228,'Kharkiv')," +
				 "(228,'Kharkov')," +
				 "(228,'Khersonska')," +
				 "(228,'Khmelnytska')," +
				 "(228,'Kirovohrad')," +
				 "(228,'Krym')," +
				 "(228,'Kyyiv')," +
				 "(228,'Kyyivska')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(228,'Lvivska')," +
				 "(228,'Luhanska')," +
				 "(228,'Mykolayivska')," +
				 "(228,'Odeska')," +
				 "(228,'Odessa')," +
				 "(228,'Poltavska')," +
				 "(228,'Rivnenska')," +
				 "(228,'Sevastopol')," +
				 "(228,'Sumska')," +
				 "(228,'Ternopilska')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(228,'Volynska')," +
				 "(228,'Vynnytska')," +
				 "(228,'Zakarpatska')," +
				 "(228,'Zaporizhia')," +
				 "(228,'Zhytomyrska')," +
				 "(229,'Abu Zabi')," +
				 "(229,'Ajman')," +
				 "(229,'Dubai')," +
				 "(229,'Ras al-Khaymah')," +
				 "(229,'Sharjah')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(229,'Sharjha')," +
				 "(229,'Umm al Qaywayn')," +
				 "(229,'al-Fujayrah')," +
				 "(229,'ash-Shariqah')," +
				 "(230,'Aberdeen')," +
				 "(230,'Aberdeenshire')," +
				 "(230,'Argyll')," +
				 "(230,'Armagh')," +
				 "(230,'Bedfordshire')," +
				 "(230,'Belfast')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(230,'Berkshire')," +
				 "(230,'Birmingham')," +
				 "(230,'Brechin')," +
				 "(230,'Bridgnorth')," +
				 "(230,'Bristol')," +
				 "(230,'Buckinghamshire')," +
				 "(230,'Cambridge')," +
				 "(230,'Cambridgeshire')," +
				 "(230,'Channel Islands')," +
				 "(230,'Cheshire')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(230,'Cleveland')," +
				 "(230,'Co Fermanagh')," +
				 "(230,'Conwy')," +
				 "(230,'Cornwall')," +
				 "(230,'Coventry')," +
				 "(230,'Craven Arms')," +
				 "(230,'Cumbria')," +
				 "(230,'Denbighshire')," +
				 "(230,'Derby')," +
				 "(230,'Derbyshire')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(230,'Devon')," +
				 "(230,'Dial Code Dungannon')," +
				 "(230,'Didcot')," +
				 "(230,'Dorset')," +
				 "(230,'Dunbartonshire')," +
				 "(230,'Durham')," +
				 "(230,'East Dunbartonshire')," +
				 "(230,'East Lothian')," +
				 "(230,'East Midlands')," +
				 "(230,'East Sussex')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(230,'East Yorkshire')," +
				 "(230,'England')," +
				 "(230,'Essex')," +
				 "(230,'Fermanagh')," +
				 "(230,'Fife')," +
				 "(230,'Flintshire')," +
				 "(230,'Fulham')," +
				 "(230,'Gainsborough')," +
				 "(230,'Glocestershire')," +
				 "(230,'Gwent')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(230,'Hampshire')," +
				 "(230,'Hants')," +
				 "(230,'Herefordshire')," +
				 "(230,'Hertfordshire')," +
				 "(230,'Ireland')," +
				 "(230,'Isle Of Man')," +
				 "(230,'Isle of Wight')," +
				 "(230,'Kenford')," +
				 "(230,'Kent')," +
				 "(230,'Kilmarnock')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(230,'Lanarkshire')," +
				 "(230,'Lancashire')," +
				 "(230,'Leicestershire')," +
				 "(230,'Lincolnshire')," +
				 "(230,'Llanymynech')," +
				 "(230,'London')," +
				 "(230,'Ludlow')," +
				 "(230,'Manchester')," +
				 "(230,'Mayfair')," +
				 "(230,'Merseyside')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(230,'Mid Glamorgan')," +
				 "(230,'Middlesex')," +
				 "(230,'Mildenhall')," +
				 "(230,'Monmouthshire')," +
				 "(230,'Newton Stewart')," +
				 "(230,'Norfolk')," +
				 "(230,'North Humberside')," +
				 "(230,'North Yorkshire')," +
				 "(230,'Northamptonshire')," +
				 "(230,'Northants')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(230,'Northern Ireland')," +
				 "(230,'Northumberland')," +
				 "(230,'Nottinghamshire')," +
				 "(230,'Oxford')," +
				 "(230,'Powys')," +
				 "(230,'Roos-shire')," +
				 "(230,'SUSSEX')," +
				 "(230,'Sark')," +
				 "(230,'Scotland')," +
				 "(230,'Scottish Borders')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(230,'Shropshire')," +
				 "(230,'Somerset')," +
				 "(230,'South Glamorgan')," +
				 "(230,'South Wales')," +
				 "(230,'South Yorkshire')," +
				 "(230,'Southwell')," +
				 "(230,'Staffordshire')," +
				 "(230,'Strabane')," +
				 "(230,'Suffolk')," +
				 "(230,'Surrey')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(230,'Sussex')," +
				 "(230,'Twickenham')," +
				 "(230,'Tyne and Wear')," +
				 "(230,'Tyrone')," +
				 "(230,'Utah')," +
				 "(230,'Wales')," +
				 "(230,'Warwickshire')," +
				 "(230,'West Lothian')," +
				 "(230,'West Midlands')," +
				 "(230,'West Sussex')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(230,'West Yorkshire')," +
				 "(230,'Whissendine')," +
				 "(230,'Wiltshire')," +
				 "(230,'Wokingham')," +
				 "(230,'Worcestershire')," +
				 "(230,'Wrexham')," +
				 "(230,'Wurttemberg')," +
				 "(230,'Yorkshire')," +
				 "(231,'Alabama')," +
				 "(231,'Alaska')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(231,'Arizona')," +
				 "(231,'Arkansas')," +
				 "(231,'Byram')," +
				 "(231,'California')," +
				 "(231,'Cokato')," +
				 "(231,'Colorado')," +
				 "(231,'Connecticut')," +
				 "(231,'Delaware')," +
				 "(231,'District of Columbia')," +
				 "(231,'Florida')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(231,'Georgia')," +
				 "(231,'Hawaii')," +
				 "(231,'Idaho')," +
				 "(231,'Illinois')," +
				 "(231,'Indiana')," +
				 "(231,'Iowa')," +
				 "(231,'Kansas')," +
				 "(231,'Kentucky')," +
				 "(231,'Louisiana')," +
				 "(231,'Lowa')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(231,'Maine')," +
				 "(231,'Maryland')," +
				 "(231,'Massachusetts')," +
				 "(231,'Medfield')," +
				 "(231,'Michigan')," +
				 "(231,'Minnesota')," +
				 "(231,'Mississippi')," +
				 "(231,'Missouri')," +
				 "(231,'Montana')," +
				 "(231,'Nebraska')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(231,'Nevada')," +
				 "(231,'New Hampshire')," +
				 "(231,'New Jersey')," +
				 "(231,'New Jersy')," +
				 "(231,'New Mexico')," +
				 "(231,'New York')," +
				 "(231,'North Carolina')," +
				 "(231,'North Dakota')," +
				 "(231,'Ohio')," +
				 "(231,'Oklahoma')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(231,'Ontario')," +
				 "(231,'Oregon')," +
				 "(231,'Pennsylvania')," +
				 "(231,'Ramey')," +
				 "(231,'Rhode Island')," +
				 "(231,'South Carolina')," +
				 "(231,'South Dakota')," +
				 "(231,'Sublimity')," +
				 "(231,'Tennessee')," +
				 "(231,'Texas')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(231,'Trimble')," +
				 "(231,'Utah')," +
				 "(231,'Vermont')," +
				 "(231,'Virginia')," +
				 "(231,'Washington')," +
				 "(231,'West Virginia')," +
				 "(231,'Wisconsin')," +
				 "(231,'Wyoming')," +
				 "(232,'United States Minor Outlying I')," +
				 "(233,'Artigas')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(233,'Canelones')," +
				 "(233,'Cerro Largo')," +
				 "(233,'Colonia')," +
				 "(233,'Durazno')," +
				 "(233,'FLorida')," +
				 "(233,'Flores')," +
				 "(233,'Lavalleja')," +
				 "(233,'Maldonado')," +
				 "(233,'Montevideo')," +
				 "(233,'Paysandu')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(233,'Rio Negro')," +
				 "(233,'Rivera')," +
				 "(233,'Rocha')," +
				 "(233,'Salto')," +
				 "(233,'San Jose')," +
				 "(233,'Soriano')," +
				 "(233,'Tacuarembo')," +
				 "(233,'Treinta y Tres')," +
				 "(234,'Andijon')," +
				 "(234,'Buhoro')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(234,'Buxoro Viloyati')," +
				 "(234,'Cizah')," +
				 "(234,'Fargona')," +
				 "(234,'Horazm')," +
				 "(234,'Kaskadar')," +
				 "(234,'Korakalpogiston')," +
				 "(234,'Namangan')," +
				 "(234,'Navoi')," +
				 "(234,'Samarkand')," +
				 "(234,'Sirdare')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(234,'Surhondar')," +
				 "(234,'Toskent')," +
				 "(235,'Malampa')," +
				 "(235,'Penama')," +
				 "(235,'Sanma')," +
				 "(235,'Shefa')," +
				 "(235,'Tafea')," +
				 "(235,'Torba')," +
				 "(236,'Vatican City State Holy See')," +
				 "(237,'Amazonas')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(237,'Anzoategui')," +
				 "(237,'Apure')," +
				 "(237,'Aragua')," +
				 "(237,'Barinas')," +
				 "(237,'Bolivar')," +
				 "(237,'Carabobo')," +
				 "(237,'Cojedes')," +
				 "(237,'Delta Amacuro')," +
				 "(237,'Distrito Federal')," +
				 "(237,'Falcon')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(237,'Guarico')," +
				 "(237,'Lara')," +
				 "(237,'Merida')," +
				 "(237,'Miranda')," +
				 "(237,'Monagas')," +
				 "(237,'Nueva Esparta')," +
				 "(237,'Portuguesa')," +
				 "(237,'Sucre')," +
				 "(237,'Tachira')," +
				 "(237,'Trujillo')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(237,'Vargas')," +
				 "(237,'Yaracuy')," +
				 "(237,'Zulia')," +
				 "(238,'Bac Giang')," +
				 "(238,'Binh Dinh')," +
				 "(238,'Binh Duong')," +
				 "(238,'Da Nang')," +
				 "(238,'Dong Bang Song Cuu Long')," +
				 "(238,'Dong Bang Song Hong')," +
				 "(238,'Dong Nai')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(238,'Dong Nam Bo')," +
				 "(238,'Duyen Hai Mien Trung')," +
				 "(238,'Hanoi')," +
				 "(238,'Hung Yen')," +
				 "(238,'Khu Bon Cu')," +
				 "(238,'Long An')," +
				 "(238,'Mien Nui Va Trung Du')," +
				 "(238,'Thai Nguyen')," +
				 "(238,'Thanh Pho Ho Chi Minh')," +
				 "(238,'Thu Do Ha Noi')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(238,'Tinh Can Tho')," +
				 "(238,'Tinh Da Nang')," +
				 "(238,'Tinh Gia Lai')," +
				 "(239,'Anegada')," +
				 "(239,'Jost van Dyke')," +
				 "(239,'Tortola')," +
				 "(240,'Saint Croix')," +
				 "(240,'Saint John')," +
				 "(240,'Saint Thomas')," +
				 "(241,'Alo')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(241,'Singave')," +
				 "(241,'Wallis')," +
				 "(242,'Bu Jaydur')," +
				 "(242,'Wad-adh-Dhahab')," +
				 "(242,'al-Ayun')," +
				 "(242,'as-Samarah')," +
				 "(243,'Adan')," +
				 "(243,'Abyan')," +
				 "(243,'Dhamar')," +
				 "(243,'Hadramaut')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(243,'Hajjah')," +
				 "(243,'Hudaydah')," +
				 "(243,'Ibb')," +
				 "(243,'Lahij')," +
				 "(243,'Marib')," +
				 "(243,'Madinat Sana')," +
				 "(243,'Sadah')," +
				 "(243,'Sana')," +
				 "(243,'Shabwah')," +
				 "(243,'Taizz')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(243,'al-Bayda')," +
				 "(243,'al-Hudaydah')," +
				 "(243,'al-Jawf')," +
				 "(243,'al-Mahrah')," +
				 "(243,'al-Mahwit')," +
				 "(244,'Central Serbia')," +
				 "(244,'Kosovo and Metohija')," +
				 "(244,'Montenegro')," +
				 "(244,'Republic of Serbia')," +
				 "(244,'Serbia')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(244,'Vojvodina')," +
				 "(245,'Central')," +
				 "(245,'Copperbelt')," +
				 "(245,'Eastern')," +
				 "(245,'Luapala')," +
				 "(245,'Lusaka')," +
				 "(245,'North-Western')," +
				 "(245,'Northern')," +
				 "(245,'Southern')," +
				 "(245,'Western')");
			Sql("INSERT INTO states (countryid,statename) VALUES" +
				 "(246,'Bulawayo')," +
				 "(246,'Harare')," +
				 "(246,'Manicaland')," +
				 "(246,'Mashonaland Central')," +
				 "(246,'Mashonaland East')," +
				 "(246,'Mashonaland West')," +
				 "(246,'Masvingo')," +
				 "(246,'Matabeleland North')," +
				 "(246,'Matabeleland South')," +
				 "(246,'Midlands')");
		}
        
        public override void Down()
        {
        }
    }
}
