using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryNetwork
{
    public static class Constants
    {
        const string CyrillicLowerChar = "[а-яё]";
        const string CyrillicUpperChar = "[А-ЯЁ]";
        const string LatinLowerChar = "[a-z]";
        const string LatinUpperChar = "[A-Z]";

        public const int NAME_MAX_LENGTH = 300;
        public const int CITY_MAX_LENGTH = 200;
        public const int COUNTRY_MAX_LENGTH = 200;

        public const int PERSON_LASTNAME_MAX_LENGTH = 200;
        public const int PERSON_FIRSTNAME_MAX_LENGTH = 50;

        public const int PUBLISHER_MAX_LENGTH = 200;

        public const int NOTE_MAX_LENGTH = 2000;
        public const string NOTE_REGEX = @"^.{0,2000}$";

        // Cyrillic or latin chars, first char should be in upper case.
        public const string NICE_NAME_REGEX = @"^([A-Z][a-z]{0,}|[А-ЯЁ][а-яё]{0,})$";

        public const string COUNRTY_ABBR_REGEX = @"^([A-Z][a-z]{0,}|[А-ЯЁ][а-яё]{0,}|[А-ЯЁA-Z]{1,})$";

        public const string ISBN_REGEX = @"^ISBN (?=.{13}$)([0-7]|(8[0-9]|9[0-4])|9([5-8][0-9]|9[0-3])|99[4-8][0-9]|999[0-9]{2})([-])\d{1,7}\-\d{1,6}\-(\d|X)$";
        

        public const string ISSN_REGEX = @"^\d{4}\-\d{4}$";
        public const string NAMESPACE = "http://rv-home.ru/LibraryNetwork";
    }
}