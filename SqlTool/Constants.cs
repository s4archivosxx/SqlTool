using System.IO;

namespace SqlTool
{
    public class Constants
    {
        protected StreamWriter StreamWriter { get; set; }
        protected string path;
        protected const string s_line = "-- --------------------------------------------------------------------------------------------------------------------------------------------";

        public Constants(string fpath)
        {
            path = fpath;
        }

        public void Write(string message)
        {
            StreamWriter.WriteLine(message);
        }

        public void WriteInsertSQuery(string id, string main, string submain, string gender)
        {
            var msg = Query("INSERT INTO shop_items (Id, RequiredGender, IsDestroyable, MainTab, SubTab) VALUES ('{0}', '{1}', '1', '{2}', '{3}');", id, gender, main, submain);
            WriteLine(msg);
        }

        public void WriteInsertSQuery(MysqlShopInfo info)
        {
            var msg = Query("INSERT INTO shop_items (Id, RequiredGender, IsDestroyable, MainTab, SubTab) VALUES ('{0}', '{1}', '1', '{2}', '{3}');", info.Id, info.Gender, info.Main, info.SubMain);
            WriteLine(msg);
        }

        public void WriteInsertSIQuery(string id, string price, string eff)
        {
            var msg = Query("INSERT INTO shop_iteminfos (ShopItemId, PriceGroupId, EffectGroupId, DiscountPercentage, IsEnabled) VALUES ('{0}', '{1}', '{2}', '0', '1');", id, price, eff);
            WriteLine(msg);
        }

        public void WriteInsertSIQuery(MysqlShopInfo info)
        {
            var msg = Query("INSERT INTO shop_iteminfos (ShopItemId, PriceGroupId, EffectGroupId, DiscountPercentage, IsEnabled) VALUES ('{0}', '{1}', '{2}', '0', '{3}');", info.Id, info.PriceGroupId, info.EffectGroupId, info.IsEnabled ? 1 : 0);
            WriteLine(msg);
        }

        public virtual void WriteUpdateSQuery(string id, string sex, string main, string subM)
        {
            var msg = Query("UPDATE shop_items SET RequiredGender='{0}', MainTab='{1}', SubTab='{2}' WHERE (Id='{3}');", sex, main, subM, id);
            WriteLine(msg);
        }

        public virtual void WriteUpdateSQuery(MysqlShopInfo info)
        {
            var msg = Query("UPDATE shop_items SET RequiredLevel='{0}', LevelLimit='{1}' WHERE (Id='{2}');", info.PriceGroupId, info.EffectGroupId, info.Id);
            WriteLine(msg);
            if (info.IsEnabled)
            {
                msg = Query("UPDATE shop_iteminfos SET PriceGroupId='46' WHERE (Id='{0}');", info.Id);
                WriteLine(msg);
            }
        }

        public void WriteDate()
        {
            WriteLine();
            WriteLine();
            WriteLine(Query("{0}{1}-- Fecha: {2}{1}{0}", s_line, System.Environment.NewLine, System.DateTime.Now));
            WriteLine();
        }

        protected string Query(string value, params object[] args) => string.Format(value, args);

        protected void WriteLine(string value = null)
        {
            if (StreamWriter == null)
                Open();

            StreamWriter.WriteLine(value ?? "");
        }

        public void Close(bool value)
        {
            if (value)
            {
                Close();
                SetNull();
            }
        }

        protected void Open() => StreamWriter = File.AppendText(path);

        protected void Close() => StreamWriter.Close();

        protected void SetNull() => StreamWriter = null;
    }

    public class MysqlShopInfo
    {
        public uint Id { get; set; }

        public int PriceGroupId { get; set; }

        public int EffectGroupId { get; set; }

        public byte Gender { get; set; }

        public byte Main { get; set; }

        public byte SubMain { get; set; }

        public bool IsEnabled { get; set; }
    }

    public static class SimpleConverts
    {
        public static bool ToBool(this string s) => bool.Parse(s);
        public static sbyte ToSByte(this string s) => sbyte.Parse(s);
        public static byte ToByte(this string s) => byte.Parse(s);
        public static uint ToUInt(this string s) => uint.Parse(s);
        public static int ToInt(this string s) => int.Parse(s);
        public static ulong ToUlong(this string s) => ulong.Parse(s);
        public static long ToLong(this string s) => long.Parse(s);
        public static System.DateTime ToDateTime(this string s) => System.DateTime.Parse(s);
        public static System.Net.IPAddress ToIpAddress(this string s) => System.Net.IPAddress.Parse(s);
        public static System.Version ToVersion(this string s) => System.Version.Parse(s);
        public static System.Uri ToUri(this string s) => new System.Uri(s);
        public static T ToObject<T>(this object s) => (T)s;
    }

    public enum ShopMain : byte
    {
        HotAndNew,
        CapsuleAndSet,
        WeaponAndSkill,
        Costume,
        Item,
        GiftList
    }

    public enum SubMainCapsule : byte
    {
        Total,
        Costume,
        Melee,
        Rifle,
        Etc,
        Pet,
        PEN,
        SetItem
    }

    public enum SubMainWeapons : byte
    {
        Total,
        Melee,
        Rifle,
        Guns,
        HeavyGune,
        Snipe,
        Especial,
        Lanzado,
        Skill
    }

    public enum SubMainCostume : byte
    {
        Total,
        Head,
        Face,
        Jacket,
        Pans,
        Gloves,
        Shoes,
        Accesory,
        Pet
    }

    public enum Gender : byte
    {
        Unisex,
        Male,
        Female
    }
}
