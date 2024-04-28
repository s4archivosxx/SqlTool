using System;
using System.Text;
using System.Windows.Forms;

namespace SqlTool
{
    public partial class FormSqlTool : Form
    {
        private Constants Constants { get; set; }

        public FormSqlTool()
        {
            InitializeComponent();
            ConfigEvents();
            Constants = new Constants("SqlTool.sql");
        }

        protected void ConfigEvents()
        {
            BtnInsert.Click += ActionClick;
            BtnUpdate.Click += ActionClick;
            TxtbId.KeyDown += SaveFile;
            TxtbType.KeyDown += SaveFile;
            TxtbMain.KeyDown += SaveFile;
            TxtbSubMain.KeyDown += SaveFile;
            TxtbGender.KeyDown += SaveFile;
            TxtbEff.KeyDown += SaveFile;
        }

        protected MysqlShopInfo RefreshMysqlShopInfo()
        {
            return new MysqlShopInfo
            {
                Id = TxtbId.Text.ToUInt(),
                PriceGroupId = TxtbPrice.Text.ToInt(),
                EffectGroupId = TxtbEff.Text.ToInt(),
                Gender = TxtbGender.Text.ToByte(),
                Main = TxtbMain.Text.ToByte(),
                SubMain = TxtbSubMain.Text.ToByte(),
                IsEnabled = TxtbIsEnabled.Text == "1" ? true : false
            };
        }

        private void TxtbMain_TextChanged(object sender, EventArgs e) => SetToolStrip(TxtbMain, "Main");
        private void TxtbSubMain_TextChanged(object sender, EventArgs e) => SetToolStrip(TxtbSubMain, "SubMain", TxtbMain);
        private void TxtbGender_TextChanged(object sender, EventArgs e) => SetToolStrip(TxtbGender, "Gender");

        private void ActionClick(object sender, EventArgs e)
        {
            var btn = (Control)sender;
            var mysqlinfo = RefreshMysqlShopInfo();

            switch (TxtbType.Text.ToUpper())
            {
                case "ISHOP":
                    if (TxtbId.Text == "" || TxtbType.Text == "")
                        return;

                    if (btn.Text.Equals("INSERTAR"))
                        Constants.WriteInsertSQuery(mysqlinfo);
                    else
                        Constants.WriteUpdateSQuery(mysqlinfo);
                    break;

                case "ISHOPINFO":
                    if (TxtbId.Text == "" || TxtbType.Text == "")
                        return;

                    if (btn.Text.Equals("INSERTAR"))
                        Constants.WriteInsertSIQuery(mysqlinfo);
                    break;

                case "DATE":
                    Constants.WriteDate();
                    break;

                case "OPEN":
                    System.Diagnostics.Process.Start("ref.txt");
                    break;

                default:
                    MessageBox.Show($"No se puede reconocer el tipo: {TxtbType.Text}", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            LabelBackup.Text = "Ultimo backup: \n" + TxtbId.Text + ":" + TxtbType.Text.ToUpper();
        }

        void SaveFile(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.S:
                        Constants.Close(true);
                        break;
                }
            }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        ActionClick(BtnInsert, null);
                        break;

                    case Keys.Space:
                        ActionClick(BtnUpdate, null);
                        break;
                }
            }
        }

        private void SetToolStrip(Control control, string type, Control control3 = null)
        {
            bool ascii = true;
            if (string.IsNullOrEmpty(control.Text) || string.IsNullOrWhiteSpace(control.Text)
                || (ascii && Encoding.UTF8.GetByteCount(control.Text) != control.Text.Length))
                return;

            switch (type)
            {
                case "Main":
                    SToolTip.SetToolTip(control, $"Type: {(ShopMain)byte.Parse(control.Text)}");
                    break;

                case "SubMain":
                    if (control3?.Text == "2")
                        SToolTip.SetToolTip(control, $"Type: {control.Text.ToByte().ToObject<SubMainWeapons>()}");
                    else if (control3?.Text == "3")
                        SToolTip.SetToolTip(control, $"Type: {control.Text.ToByte().ToObject<SubMainCostume>()}");
                    else
                        SToolTip.SetToolTip(control, $"Type: {control.Text.ToByte().ToObject<SubMainCapsule>()}");
                    break;

                case "Gender":
                    SToolTip.SetToolTip(control, $"Type: {control.Text.ToByte().ToObject<Gender>()}");
                    break;
            }
        }
    }
}
