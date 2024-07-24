using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_test.service
{
    internal static class HandlesText
    {
        public static string TheWordingDate(string day, string dayMonth, string month, string year)
        {
            if (dayMonth == "30")
            {
                return $"{daysOfWeek[day]} יום {daysOfMonth[dayMonth]} לחדש {month} שהוא ראש חודש {month} שנת {Year[year]} לבריאת העולם";
            }
            else if (dayMonth == "1")
            {
                return $"{daysOfWeek[day]} יום {daysOfMonth[dayMonth]} לירח {month} שנת {Year[year]} לבריאת העולם";
            }
            else return $"{daysOfWeek[day]}  {daysOfMonth[dayMonth]}  ימים לירח {month} שנת {Year[year]} לבריאת העולם"; ;
        }

        static Dictionary<string, string> daysOfWeek = new Dictionary<string, string>()
        {
            { "ראשון","באחד בשבת" },
            { "שני", "בשני בשבת" },
            { "שלישי", "בשלישי בשבת" },
            { "רביעי", "ברביעי בשבת" },
            { "חמישי", "בחמישי בשבת" },
            {"ששי", "בששי בשבת" }
        };

        static Dictionary<string, string> daysOfMonth = new Dictionary<string, string>()
        {
            { "1","אחד" },
            { "2", "שני" },
            { "3", "שלשה" },
            { "4", "ארבעה" },
            { "5", "חמשה" },
            { "6", "ששה" },
            { "7", "שבעה" },
            { "8", "שמנה" },
            { "9", "תשעה" },
            { "10", "עשרה" },
            { "11", "אחד עשר" },
            { "12", "שנים עשר" },
            { "13", "שלשה עשר" },
            { "14", "ארבעה עשר" },
            { "15", "חמשה עשר" },
            { "16", "ששה עשר" },
            { "17", "שבעה עשר" },
            { "18", "שמנה עשר" },
            { "19", "תשעה עשר" },
            { "20", "עשרים" },
            { "21", "אחד ועשרים" },
            { "22", "שנים ועשרים" },
            { "23", "שלשה ועשרים" },
            { "24", "ארבעה ועשרים" },
            { "25", "חמישה ועשרים" },
            { "26", "ששה עשרים" },
            { "27", "שבעה ועשרים" },
            { "28", "שמנה ועשרים" },
            { "29", "תשעה ועשרים" },
            { "30", "שלושים" }

        };
        static Dictionary<string, string> Year = new Dictionary<string, string>()
        {
            {"תשפ\"ד","חמשת אלפים ושבע מאות ושמנים וארבע" },
            {"תשפ\"ה", "חמשת אלפים ושבע מאות ושמנים וחמשה" },
            {"תשפ\"ו", "חמשת אלפים ושבע מאות ושמנים וששה" },
            {"תשפ\"ז", "ברביעי בשבת" },
            {"תשפ\"ח", "בחמישי בשבת" },
            {"תשפ\"ט", "בששי בשבת" },
            {"תש\"צ", "בששי בשבת" },
            {"תשצ\"א", "ברביעי בשבת" },
            {"תשצ\"ב", "בחמישי בשבת" },
            {"תשצ\"ג\r\n", "בששי בשבת" }


        };
    }
    
        
}


    