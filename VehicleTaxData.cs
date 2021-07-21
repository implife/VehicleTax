using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLicenseTaxCalculator
{
    class VehicleTaxData
    {
        // 小客車資料
        private static string[] _LittleCarDisplacement = {
            "500cc 以下 / 38HP以下(38.6PS以下)", "501cc - 600cc / 38.1-56HP(38.7-56.8PS)",
            "601cc - 1200cc / 56.1-83HP(56.9-84.2PS)", "1201cc - 1800cc / 83.1-182HP(84.3-184.7PS)",
            "1801cc - 2400cc / 182.1-262HP(184.8-265.9PS)", "2401cc - 3000cc / 262.1-322HP(266-326.8PS)",
            "3001cc - 4200cc / 322.1-414HP(326.9-420.2PS", "4201cc - 5400cc / 414.1-469HP(420.3-476.0PS)",
            "5401cc - 6600cc / 469.1-509HP(476.1-516.6PS)", "6601cc - 7800cc / 509.1HP以上(516.7PS以上)",
            "7801cc以上"
        };
        private static int[] _LittleCarSelfUseTax = { 1620, 2160, 4320, 7120, 11230, 15210, 28220, 46170, 69690, 117000, 151200 };
        private static int[] _LittleCarBusinessUseTax = { 900, 1260, 2160, 3060, 6480, 9900, 16380, 24300, 33660, 44460, 56700 };

        // 大客車和貨車資料
        private static string[] _BigCarDisplacement = {
            "500cc 以下", "501cc - 600cc", "601cc - 1200cc", "1201cc - 1800cc",
            "1801cc - 2400cc", "2401cc - 3000cc / 138HP以下(140.1PS以下)", "3001cc - 3600cc",
            "3601cc - 4200cc / 138.1-200HP(140.2-203.0PS)", "4201cc - 4800cc",
            "4801cc - 5400cc / 200.1-247HP(203.1-250.7PS)", "5401cc - 6000cc",
            "6001cc - 6600cc / 247.1-286HP(250.8-290.3PS)","6601cc - 7200cc",
            "7201cc - 7800cc / 286.1-336HP(290.4-341.0PS)", "7801cc - 8400cc",
            "8401cc - 9000cc / 336.1-361HP(341.1-366.4PS)","9001cc - 9600cc",
            "9601cc - 10200cc / 361.1HP以上(366.5PS以上)", "10201以上"
        };
        private static int[] _BusTax = {
            0, 1080, 1800, 2700, 3600, 4500, 5400, 6300, 7200, 8100,
            9000, 9900, 10800, 11700, 12600, 13500, 14400, 15300, 16200
        };
        private static int[] _TruckTax = {
            900, 1080, 1800, 2700, 3600, 4500, 5400, 6300, 7200, 8100,
            9000, 9900, 10800, 11700, 12600, 13500, 14400, 15300, 16200
        };

        // 機車資料
        private static string[] _MotorcycleDisplacement = {
            "150cc 以下 / 12HP以下(12.2PS以下)", "151cc - 250cc / 12.1 - 20HP(12.3 - 20.3PS)",
            "251cc - 500cc / 20.1HP以上(20.4PS以上)", "501cc - 600cc",
            "601cc - 1200cc", "1201cc - 1800cc", "1801cc以上"
        };
        private static int[] _MotorcycleTax = { 0, 800, 1620, 2160, 3600, 4320, 7120, 11230 };


        // 傳入類型取得汽缸數的陣列
        public static string[] getDisplacementAry(string type)
        {
            switch (type)
            {
                case "自用小客車":
                    return _LittleCarDisplacement;
                case "營業用小客車":
                    return _LittleCarDisplacement;
                case "大客車":
                    return _BigCarDisplacement;
                case "貨車":
                    return _BigCarDisplacement;
                case "機車":
                    return _MotorcycleDisplacement;
                default:
                    return new string[] { "null" };
            }
        }

        // 利用類型和汽缸數取得年額度
        public static int getTax(string type, string displacement)
        {
            switch (type)
            {
                case "自用小客車":
                    int i = Array.IndexOf(_LittleCarDisplacement, displacement);
                    return i != -1 ? _LittleCarSelfUseTax[i] : -1;
                case "營業用小客車":
                    int j = Array.IndexOf(_LittleCarDisplacement, displacement);
                    return j != -1 ? _LittleCarBusinessUseTax[j] : -1;
                case "大客車":
                    int k = Array.IndexOf(_BigCarDisplacement, displacement);
                    return k != -1 ? _BusTax[k] : -1;
                case "貨車":
                    int x = Array.IndexOf(_BigCarDisplacement, displacement);
                    return x != -1 ? _TruckTax[x] : -1;
                case "機車":
                    int y = Array.IndexOf(_MotorcycleDisplacement, displacement);
                    return y != -1 ? _MotorcycleTax[y] : -1;
                default:
                    return -1;
            }
        }
    }
}
