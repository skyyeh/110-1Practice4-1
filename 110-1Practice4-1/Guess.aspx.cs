using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1Practice4_1 {
    public partial class Guess : System.Web.UI.Page {
        public bool b_IsBingo = false;

        protected void Page_Load(object sender, EventArgs e) {
            if (lb_Res.Text == "") {
                lb_Res.Text = mt_Gen();
            }
            else if (Convert.ToInt32(tb_Rem.Text) <= 1) {
                tb_Num.Enabled = false;
            }
        }

        public string mt_Gen() {
            string s_Res = "";
            // Generate a array for producing a 4-digital number            
            int[] ia_Rom = new int[10];
            for (int i_Ct = 0; i_Ct < 10; i_Ct++) {
                ia_Rom[i_Ct] = i_Ct;
            }

            // Generate a 4-digital number
            int i_BoundI = 9;
            Random o_R = new Random();
            for (int i_Ct = 0; i_Ct < 4; i_Ct++) {
                int i_SelectInd = o_R.Next(0, i_BoundI + 1);
                s_Res = s_Res + ia_Rom[i_SelectInd].ToString();

                int i_Tmp = ia_Rom[i_BoundI];
                ia_Rom[i_BoundI] = ia_Rom[i_SelectInd];
                ia_Rom[i_SelectInd] = i_Tmp;
                i_BoundI--;
            }
            return s_Res;
        }

        public string mt_ShowAB() {
            string s_Res = lb_Res.Text;
            string s_Num = tb_Num.Text;
            int i_NumA = 0;
            int i_NumB = 0;

            for (int i_Ct = 0; i_Ct < 4; i_Ct++) {
                if (s_Res[i_Ct] == s_Num[i_Ct]) {
                    i_NumA++;
                }
            }

            for (int i_Ct = 0; i_Ct < 4; i_Ct++) {
                for (int i_Ct2 = 0; i_Ct2 < 4; i_Ct2++) {
                    if (s_Res[i_Ct] == s_Num[i_Ct2] && i_Ct != i_Ct2) {
                        i_NumB++;
                    }
                }
            }

            if (i_NumA == 4) {
                b_IsBingo = true;
            }
            return i_NumA.ToString() + "A" + i_NumB.ToString() + "B";
        }
    }
}