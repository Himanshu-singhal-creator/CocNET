﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocNET.Includes
{
    public class Locations
    {
        public enum AllLocations
        {
            Europe = 32000000,
            North_America = 32000001,
            South_America = 32000002,
            Asia = 32000003,
            Australia = 32000004,
            Africa = 32000005,
            International = 32000006,
            Afghanistan = 32000007,
            Åland_Islands = 32000008,
            Albania_ = 32000009,
            Algeria = 32000010,
            American_Samoa = 32000011,
            Andorra = 32000012,
            Angola = 32000013,
            Anguilla = 32000014,
            Antarctica = 32000015,
            Antigua_and_Barbuda = 32000016,
            Argentina = 32000017,
            Armenia = 32000018,
            Aruba = 32000019,
            Ascension_Island = 32000020,
            Austria = 32000022,
            Azerbaijan = 32000023,
            Bahamas = 32000024,
            Bahrain = 32000025,
            Bangladesh = 32000026,
            Barbados = 32000027,
            Belarus = 32000028,
            Belgium = 32000029,
            Belize = 32000030,
            Benin = 32000031,
            Bermuda = 32000032,
            Bhutan = 32000033,
            Bolivia = 32000034,
            Bosnia_and_Herzegovina = 32000035,
            Botswana = 32000036,
            Bouvet_Island = 32000037,
            Brazil = 32000038,
            British_Indian_Ocean_Territory = 32000039,
            British_Virgin_Islands = 32000040,
            Brunei = 32000041,
            Bulgaria = 32000042,
            Burkina_Faso = 32000043,
            Burundi = 32000044,
            Cambodia = 32000045,
            Cameroon = 32000046,
            Canada = 32000047,
            Canary_Islands = 32000048,
            Cape_Verde = 32000049,
            Caribbean_Netherlands = 32000050,
            Cayman_Islands = 32000051,
            Central_African_Republic = 32000052,
            Ceuta_and_Melilla = 32000053,
            Chad = 32000054,
            Chile = 32000055,
            China = 32000056,
            Christmas_Island = 32000057,
            Cocos_Keeling_Islands = 32000058,
            Colombia = 32000059,
            Comoros = 32000060,
            Congo_DRC_ = 32000061,
            Congo_Republic_ = 32000062,
            Cook_Islands = 32000063,
            Costa_Rica = 32000064,
            Côte_d_Ivoire = 32000065,
            Croatia = 32000066,
            Cuba = 32000067,
            Curaçao = 32000068,
            Cyprus = 32000069,
            Czech_Republic = 32000070,
            Denmark = 32000071,
            Diego_Garcia = 32000072,
            Djibouti = 32000073,
            Dominica = 32000074,
            Dominican_Republic = 32000075,
            Ecuador = 32000076,
            Egypt = 32000077,
            El_Salvador = 32000078,
            Equatorial_Guinea = 32000079,
            Eritrea = 32000080,
            Estonia = 32000081,
            Ethiopia = 32000082,
            Falkland_Islands = 32000083,
            Faroe_Islands = 32000084,
            Fiji = 32000085,
            Finland = 32000086,
            France = 32000087,
            French_Guiana = 32000088,
            French_Polynesia = 32000089,
            French_Southern_Territories = 32000090,
            Gabon = 32000091,
            Gambia = 32000092,
            Georgia = 32000093,
            Germany = 32000094,
            Ghana = 32000095,
            Gibraltar = 32000096,
            Greece = 32000097,
            Greenland = 32000098,
            Grenada = 32000099,
            Guadeloupe = 32000100,
            Guam = 32000101,
            Guatemala = 32000102,
            Guernsey = 32000103,
            Guinea = 32000104,
            Guinea_Bissau = 32000105,
            Guyana = 32000106,
            Haiti = 32000107,
            Heard_McDonald_Islands = 32000108,
            Honduras = 32000109,
            Hong_Kong = 32000110,
            Hungary = 32000111,
            Iceland = 32000112,
            India = 32000113,
            Indonesia = 32000114,
            Iran = 32000115,
            Iraq = 32000116,
            Ireland = 32000117,
            Isle_of_Man = 32000118,
            Israel = 32000119,
            Italy = 32000120,
            Jamaica = 32000121,
            Japan = 32000122,
            Jersey = 32000123,
            Jordan = 32000124,
            Kazakhstan = 32000125,
            Kenya = 32000126,
            Kiribati = 32000127,
            Kosovo = 32000128,
            Kuwait = 32000129,
            Kyrgyzstan = 32000130,
            Laos = 32000131,
            Latvia = 32000132,
            Lebanon = 32000133,
            Lesotho = 32000134,
            Liberia = 32000135,
            Libya = 32000136,
            Liechtenstein = 32000137,
            Lithuania = 32000138,
            Luxembourg = 32000139,
            Macau = 32000140,
            Macedonia_FYROM_ = 32000141,
            Madagascar = 32000142,
            Malawi = 32000143,
            Malaysia = 32000144,
            Maldives = 32000145,
            Mali = 32000146,
            Malta = 32000147,
            Marshall_Islands = 32000148,
            Martinique = 32000149,
            Mauritania = 32000150,
            Mauritius = 32000151,
            Mayotte = 32000152,
            Mexico = 32000153,
            Micronesia = 32000154,
            Moldova = 32000155,
            Monaco = 32000156,
            Mongolia = 32000157,
            Montenegro = 32000158,
            Montserrat = 32000159,
            Morocco = 32000160,
            Mozambique = 32000161,
            Myanmar_Burma_ = 32000162,
            Namibia = 32000163,
            Nauru = 32000164,
            Nepal = 32000165,
            Netherlands = 32000166,
            New_Caledonia = 32000167,
            New_Zealand = 32000168,
            Nicaragua = 32000169,
            Niger = 32000170,
            Nigeria = 32000171,
            Niue = 32000172,
            Norfolk_Island = 32000173,
            North_Korea = 32000174,
            Northern_Mariana_Islands = 32000175,
            Norway = 32000176,
            Oman = 32000177,
            Pakistan = 32000178,
            Palau = 32000179,
            Palestine = 32000180,
            Panama = 32000181,
            Papua_New_Guinea = 32000182,
            Paraguay = 32000183,
            Peru = 32000184,
            Philippines = 32000185,
            Pitcairn_Islands = 32000186,
            Poland = 32000187,
            Portugal = 32000188,
            Puerto_Rico = 32000189,
            Qatar = 32000190,
            Réunion = 32000191,
            Romania = 32000192,
            Russia = 32000193,
            Rwanda = 32000194,
            Saint_Barthélemy = 32000195,
            Saint_Helena = 32000196,
            Saint_Kitts_and_Nevis = 32000197,
            Saint_Lucia = 32000198,
            Saint_Martin = 32000199,
            Saint_Pierre_and_Miquelon = 32000200,
            Samoa = 32000201,
            San_Marino = 32000202,
            São_Tomé_and_Príncipe = 32000203,
            Saudi_Arabia = 32000204,
            Senegal = 32000205,
            Serbia = 32000206,
            Seychelles = 32000207,
            Sierra_Leone = 32000208,
            Singapore = 32000209,
            Sint_Maarten = 32000210,
            Slovakia = 32000211,
            Slovenia = 32000212,
            Solomon_Islands = 32000213,
            Somalia = 32000214,
            South_Africa = 32000215,
            South_Korea = 32000216,
            South_Sudan = 32000217,
            Spain = 32000218,
            Sri_Lanka = 32000219,
            St_Vincent_Grenadines = 32000220,
            Sudan = 32000221,
            Suriname = 32000222,
            Svalbard_and_Jan_Mayen = 32000223,
            Swaziland = 32000224,
            Sweden = 32000225,
            Switzerland = 32000226,
            Syria = 32000227,
            Taiwan = 32000228,
            Tajikistan = 32000229,
            Tanzania = 32000230,
            Thailand = 32000231,
            Timor_Leste = 32000232,
            Togo = 32000233,
            Tokelau = 32000234,
            Tonga = 32000235,
            Trinidad_and_Tobago = 32000236,
            Tristan_da_Cunha = 32000237,
            Tunisia = 32000238,
            Turkey = 32000239,
            Turkmenistan = 32000240,
            Turks_and_Caicos_Islands = 32000241,
            Tuvalu = 32000242,
            U_S_Outlying_Islands = 32000243,
            U_S_Virgin_Islands = 32000244,
            Uganda = 32000245,
            Ukraine = 32000246,
            United_Arab_Emirates = 32000247,
            United_Kingdom = 32000248,
            United_States = 32000249,
            Uruguay = 32000250,
            Uzbekistan = 32000251,
            Vanuatu = 32000252,
            Vatican_City = 32000253,
            Venezuela = 32000254,
            Vietnam = 32000255,
            Wallis_and_Futuna = 32000256,
            Western_Sahara = 32000257,
            Yemen = 32000258,
            Zambia = 32000259,
            Zimbabwe = 32000260
        }
        public static int GetLocationId(AllLocations myLocationName)
        {
            return (int)myLocationName;
        }
    }

}