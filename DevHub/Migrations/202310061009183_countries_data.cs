namespace DevHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class countries_data : DbMigration
    {
        public override void Up()
        {
			Sql("INSERT INTO countries (name) VALUES" +
				"('Afghanistan')," +
				"('Albania')," +
				"('Algeria')," +
				"('American Samoa')," +
				"('Andorra')," +
				"('Angola')," +
				"('Anguilla')," +
				"('Antarctica')," +
				"('Antigua And Barbuda')," +
				"('Argentina')");
			Sql("INSERT INTO countries (name) VALUES" +
				 "('Armenia')," +
				 "('Aruba')," +
				 "('Australia')," +
				 "('Austria')," +
				 "('Azerbaijan')," +
				 "('Bahamas The')," +
				 "('Bahrain')," +
				 "('Bangladesh')," +
				 "('Barbados')," +
				 "('Belarus')");
			Sql("INSERT INTO countries (name) VALUES" +
				 "('Belgium')," +
				 "('Belize')," +
				 "('Benin')," +
				 "('Bermuda')," +
				 "('Bhutan')," +
				 "('Bolivia')," +
				 "('Bosnia and Herzegovina')," +
				 "('Botswana')," +
				 "('Bouvet Island')," +
				 "('Brazil')");
			Sql("INSERT INTO countries (name) VALUES" +
				 "('British Indian Ocean Territory')," +
				 "('Brunei')," +
				 "('Bulgaria')," +
				 "('Burkina Faso')," +
				 "('Burundi')," +
				 "('Cambodia')," +
				 "('Cameroon')," +
				 "('Canada')," +
				 "('Cape Verde')," +
				 "('Cayman Islands')");
			Sql("INSERT INTO countries (name) VALUES" +
				 "('Central African Republic')," +
				 "('Chad')," +
				 "('Chile')," +
				 "('China')," +
				 "('Christmas Island')," +
				 "('Cocos (Keeling) Islands')," +
				 "('Colombia')," +
				 "('Comoros')," +
				 "('Republic Of The Congo')," +
				 "('Democratic Republic Of The Congo')");
			Sql("INSERT INTO countries (name) VALUES" +
				 "('Cook Islands')," +
				 "('Costa Rica')," +
				 "('Cote DIvoire (Ivory Coast)')," +
				 "('Croatia (Hrvatska)')," +
				 "('Cuba')," +
				 "('Cyprus')," +
				 "('Czech Republic')," +
				 "('Denmark')," +
				 "('Djibouti')," +
				 "('Dominica')");
			Sql("INSERT INTO countries (name) VALUES" +
				 "('Dominican Republic')," +
				 "('East Timor')," +
				 "('Ecuador')," +
				 "('Egypt')," +
				 "('El Salvador')," +
				 "('Equatorial Guinea')," +
				 "('Eritrea')," +
				 "('Estonia')," +
				 "('Ethiopia')," +
				 "('External Territories of Australia')");
			Sql("INSERT INTO countries (name) VALUES" +
				 "('Falkland Islands')," +
				 "('Faroe Islands')," +
				 "('Fiji Islands')," +
				 "('Finland')," +
				 "('France')," +
				 "('French Guiana')," +
				 "('French Polynesia')," +
				 "('French Southern Territories')," +
				 "('Gabon')," +
				 "('Gambia The')");
			Sql("INSERT INTO countries (name) VALUES" +
				 "('Georgia')," +
				 "('Germany')," +
				 "('Ghana')," +
				 "('Gibraltar')," +
				 "('Greece')," +
				 "('Greenland')," +
				 "('Grenada')," +
				 "('Guadeloupe')," +
				 "('Guam')," +
				 "('Guatemala')");
			Sql("INSERT INTO countries (name) VALUES" +
				 "('Guernsey and Alderney')," +
				 "('Guinea')," +
				 "('Guinea-Bissau')," +
				 "('Guyana')," +
				 "('Haiti')," +
				 "('Heard and McDonald Islands')," +
				 "('Honduras')," +
				 "('Hong Kong S.A.R.')," +
				 "('Hungary')," +
				 "('Iceland')");
			Sql("INSERT INTO countries (name) VALUES" +
				 "('India')," +
				 "('Indonesia')," +
				 "('Iran')," +
				 "('Iraq')," +
				 "('Ireland')," +
				 "('Israel')," +
				 "('Italy')," +
				 "('Jamaica')," +
				 "('Japan')," +
				 "('Jersey')");
			Sql("INSERT INTO countries (name) VALUES" +
				 "('Jordan')," +
				 "('Kazakhstan')," +
				 "('Kenya')," +
				 "('Kiribati')," +
				 "('Korea North')," +
				 "('Korea South')," +
				 "('Kuwait')," +
				 "('Kyrgyzstan')," +
				 "('Laos')," +
				 "('Latvia')");
			Sql("INSERT INTO countries (name) VALUES" +
				 "('Lebanon')," +
				 "('Lesotho')," +
				 "('Liberia')," +
				 "('Libya')," +
				 "('Liechtenstein')," +
				 "('Lithuania')," +
				 "('Luxembourg')," +
				 "('Macau S.A.R.')," +
				 "('Macedonia')," +
				 "('Madagascar')");
			Sql("INSERT INTO countries (name) VALUES" +
				 "('Malawi')," +
				 "('Malaysia')," +
				 "('Maldives')," +
				 "('Mali')," +
				 "('Malta')," +
				 "('Man (Isle of)')," +
				 "('Marshall Islands')," +
				 "('Martinique')," +
				 "('Mauritania')," +
				 "('Mauritius')");
			Sql("INSERT INTO countries (name) VALUES" +
				 "('Mayotte')," +
				 "('Mexico')," +
				 "('Micronesia')," +
				 "('Moldova')," +
				 "('Monaco')," +
				 "('Mongolia')," +
				 "('Montserrat')," +
				 "('Morocco')," +
				 "('Mozambique')," +
				 "('Myanmar')");
			Sql("INSERT INTO countries (name) VALUES" +
				 "('Namibia')," +
				 "('Nauru')," +
				 "('Nepal')," +
				 "('Netherlands Antilles')," +
				 "('Netherlands The')," +
				 "('New Caledonia')," +
				 "('New Zealand')," +
				 "('Nicaragua')," +
				 "('Niger')," +
				 "('Nigeria')");
			Sql("INSERT INTO countries (name) VALUES" +
				 "('Niue')," +
				 "('Norfolk Island')," +
				 "('Northern Mariana Islands')," +
				 "('Norway')," +
				 "('Oman')," +
				 "('Pakistan')," +
				 "('Palau')," +
				 "('Palestinian Territory Occupied')," +
				 "('Panama')," +
				 "('Papua new Guinea')");
			Sql("INSERT INTO countries (name) VALUES" +
				 "('Paraguay')," +
				 "('Peru')," +
				 "('Philippines')," +
				 "('Pitcairn Island')," +
				 "('Poland')," +
				 "('Portugal')," +
				 "('Puerto Rico')," +
				 "('Qatar')," +
				 "('Reunion')," +
				 "('Romania')");
			Sql("INSERT INTO countries (name) VALUES" +
				 "('Russia')," +
				 "('Rwanda')," +
				 "('Saint Helena')," +
				 "('Saint Kitts And Nevis')," +
				 "('Saint Lucia')," +
				 "('Saint Pierre and Miquelon')," +
				 "('Saint Vincent And The Grenadines')," +
				 "('Samoa')," +
				 "('San Marino')," +
				 "('Sao Tome and Principe')");
			Sql("INSERT INTO countries (name) VALUES" +
				 "('Saudi Arabia')," +
				 "('Senegal')," +
				 "('Serbia')," +
				 "('Seychelles')," +
				 "('Sierra Leone')," +
				 "('Singapore')," +
				 "('Slovakia')," +
				 "('Slovenia')," +
				 "('Smaller Territories of the UK')," +
				 "('Solomon Islands')");
			Sql("INSERT INTO countries (name) VALUES" +
				"('Somalia')," +
				"('South Africa')," +
				"('South Georgia')," +
				"('South Sudan')," +
				"('Spain')," +
				"('Sri Lanka')," +
				"('Sudan')," +
				"('Suriname')," +
				"('Svalbard And Jan Mayen Islands')," +
				"('Swaziland')");
			Sql("INSERT INTO countries (name) VALUES" +
				 "('Sweden')," +
				 "('Switzerland')," +
				 "('Syria')," +
				 "('Taiwan')," +
				 "('Tajikistan')," +
				 "('Tanzania')," +
				 "('Thailand')," +
				 "('Togo')," +
				 "('Tokelau')," +
				 "('Tonga')");
			Sql("INSERT INTO countries (name) VALUES" +
				 "('Trinidad And Tobago')," +
				 "('Tunisia')," +
				 "('Turkey')," +
				 "('Turkmenistan')," +
				 "('Turks And Caicos Islands')," +
				 "('Tuvalu')," +
				 "('Uganda')," +
				 "('Ukraine')," +
				 "('United Arab Emirates')," +
				 "('United Kingdom')");
			Sql("INSERT INTO countries (name) VALUES" +
				 "('United States')," +
				 "('United States Minor Outlying Islands')," +
				 "('Uruguay')," +
				 "('Uzbekistan')," +
				 "('Vanuatu')," +
				 "('Vatican City State (Holy See)')," +
				 "('Venezuela')," +
				 "('Vietnam')," +
				 "('Virgin Islands (British)')," +
				 "('Virgin Islands (US)')");
			Sql("INSERT INTO countries (name) VALUES" +
				 "('Wallis And Futuna Islands')," +
				 "('Western Sahara')," +
				 "('Yemen')," +
				 "('Yugoslavia')," +
				 "('Zambia')," +
				 "('Zimbabwe')");

		}

		public override void Down()
        {
        }
    }
}
