using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace DaoDinhDuc_btl_elgamal
{
    public partial class Form1 : Form
    {
		public long p , a , x , d , k , y ;
		public static bool HasKey = false;
		public Form1()
        {
			InitializeComponent();
			atxt.Enabled = false;
			ptxt.Enabled = false;
			dtxt.Enabled = false;
			xtxt.Enabled = false;
			ktxt.Enabled = false;
			ytxt.Enabled = false;
			fileCheck.Enabled = false;
			signature.Enabled = false;
			pathFile.Enabled = false;
		}

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileName(openFileDialog1.FileName);
                string filePath = openFileDialog1.FileName;
                pathFile.Text = filePath;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileName(openFileDialog2.FileName);
                string filePath = openFileDialog2.FileName;
                fileCheck.Text = filePath;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        //tạo khoá ngẫu nhiên
        private void button1_Click(object sender, EventArgs e)
        {
            resetData();
            do
            {
                p = SoNgauNhien();

            } while (!LaSNT(p));
            try
            {
                HasKey = AutoCreateKey();
            }
            catch
            {
                MessageBox.Show("khoá chưa được tìm thấy xin vui lòng tìm lại", "error", MessageBoxButtons.OK);
            }
            atxt.Text = a.ToString();
            ptxt.Text = p.ToString();
            dtxt.Text = d.ToString();
            xtxt.Text = x.ToString();
            ktxt.Text = k.ToString();
            ytxt.Text = y.ToString();
			MessageBox.Show("Tạo khoá thành công !!!", "success", MessageBoxButtons.OK);
		}

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        #region Method
        public void resetData()
        {
            atxt.Text = "";
            ptxt.Text = "";
            dtxt.Text = "";
            xtxt.Text = "";
            ktxt.Text = "";
            ytxt.Text = "";
        }
        #endregion

        private void resetBtn_Click(object sender, EventArgs e)
        {
            resetData();
        }


		private long SoNgauNhien()
		{
			//khởi tạo đối tượng random
			Random random = new Random();
			//chọn 1 số ngẫu nhiên
			long randomNumber = (long)random.Next(1000,30000);
			return randomNumber;
		}
		/// <summary>
		/// kiểm tra 1 số xem có phải là số nguyên tố hay không
		/// </summary>
		/// <param name="number">số cần kiểm tra</param>
		/// <returns>trả về rue nếu đúng và ngược lại</returns>
		private bool LaSNT(long n)
		{
			// so nguyen n < 2 khong phai la so nguyen to
			if (n < 2)
			{
				return false;
			}
			// check so nguyen to khi n >= 2
			for (long i = 2; i <= Math.Sqrt(n); i++)
			{
				if (n % i == 0)
				{
					return false;
				}
			}
			return true;
		}
        private bool GCDLa1(long a, long b)
        {
            // b != 0 && a == 1 ? true : false;	
            long temp;
            while (b != 0)
            {
                temp = a % b;
                a = b;
                b = temp;
            }

            //kiểm tra ước 2 số có = 1 không
            if (a == 1) return true;
            else return false;
        }//GCD(a,b) = 1

        private void signingBtn_Click(object sender, EventArgs e)
        {
			if (pathFile.Text == "") { MessageBox.Show("Xin vui lòng chọn file để ký", "error", MessageBoxButtons.OK); return; }
			if (!HasKey) { MessageBox.Show("Xin vui lòng chọn file để ký", "error", MessageBoxButtons.OK); return; }
			string content = File.ReadAllText(pathFile.Text);
			signature.Text = Ky(content);
			using (File.Create(@"C:\Users\Duc\Desktop\chuky.sig.txt", 1024)){}
			using (StreamWriter sw = new StreamWriter(@"C:\Users\Duc\Desktop\chuky.sig.txt"))
            {
				sw.WriteLine(Ky(content));
				MessageBox.Show("Chữ ký đã được lưu vào trong file chuky.sig", "success", MessageBoxButtons.OK);
			}
		}

        private void pathFile_TextChanged(object sender, EventArgs e)
        {
			
		}

        private void checkSignatureBtn_Click(object sender, EventArgs e)
        {
			if (fileCheck.Text == "") { MessageBox.Show("Xin vui lòng chọn file để kiểm tra", "error", MessageBoxButtons.OK); return; }
			else {
				string content = File.ReadAllText(pathFile.Text);
				string chuKy = File.ReadAllText(fileCheck.Text).Replace("\n","").Replace("\r","");
				if (KiemTra(chuKy, content)) { 
					MessageBox.Show("Văn bản không có gì thay đổi", "Success", MessageBoxButtons.OK); 
					return; 
				}
                else
                {
					MessageBox.Show("Văn bản đã bị thay đổi", "Error", MessageBoxButtons.OK); return;
				}
			}
		}


		long NghichDaoModulo(long n, long m)
		{
			for (long i = 1; i < m; i++)
			{
				if (((long) n* i) % m == 1) {
				return i;
			}
		}
		  return 0; // not exist
		}

		private long Modulo(long Coso, long SoMu, long modulo)
		{
			//Sử dụng bình phương nhân
			List<long> a = new List<long> ();
			do
			{
				a.Add((long)SoMu % 2);
				SoMu = SoMu / 2;

			} while (SoMu != 0);

			//Lấy dư
			long result = 1;
			for (int i = a.Count - 1; i >= 0; i--)
			{
				result = (result * result) % modulo;
				if (a[i] == 1)
				{
					result = (result * Coso) % modulo;
				}
			}

			return result;
		}
		private bool AutoCreateKey()
		{
			a = x = d = k = 0;
			Random random = new Random();
			do
			{
				a = (long)random.Next(2, (int)p - 1);
			}
			while (!GCDLa1((long)a,(long)p));
			x = (long)random.Next(2, (int)p - 1);
			// d= a^x mod P
			d = Modulo(a, x, p);
			do
			{
				k = (long)random.Next(2,(int)p-1);
			} while (!GCDLa1((long)k, (long)p - 1));

			// Tính Y = A^k mod p - Khóa công khai
			y = Modulo(a, k, p);

			return true;
		} //Tạo khóa tự động
		private string HashSha256(string chuoiVao)
        {
			using (SHA256 sha256Hash = SHA256.Create())
			{
				// ComputeHash - returns byte array  
				byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(chuoiVao));

				// Convert byte array to a string   
				StringBuilder builder = new StringBuilder();
				for (int i = 0; i < bytes.Length; i++)
				{
					builder.Append(bytes[i].ToString("x2"));
				}
				return builder.ToString();
			}
		}
		private long pow_modulo(long coSo, long exponent, long m)
		{
			if (exponent == 0) return 1;
			if (exponent == 1) return coSo;
			long half = pow_modulo(coSo, exponent / 2, m);
			if (exponent % 2 == 0)
			{
				return (half * half) % m;
			}
			else
			{
				return (((half * half) % m) * coSo) % m;
			}
		}
		private string Ky(string ChuoiVao)
		{
			string hashStr = string.Empty;
			//danh so ky tu unicode
			hashStr = HashSha256(ChuoiVao);
			int n = hashStr.Length;
			List<long> mh_temp2 = new List<long>();
			for (int i = 0; i < n; i++)
			{
				mh_temp2.Add((long)hashStr[i]);
			}
			long mh_temp2length = mh_temp2.Count;
			List<long> mh_temp3 = new List<long>();

			//tính y2= (H(m) - x * y) * k^-1 * mod (p - 1)
			for (int i = 0; i < mh_temp2length; i++)
			{
				var s1 = ((mh_temp2[i] - x * y) % (p - 1)) < 0 ? ((mh_temp2[i] - x * y) % (p - 1)) + (p - 1) : ((mh_temp2[i] - x * y) % (p - 1));
				var s2 = NghichDaoModulo(k, p - 1);
				mh_temp3.Add(Modulo((long)s1*s2,1,p-1));
			}
			String banMaHoa = string.Empty;
			long mh_temp3length = mh_temp3.Count;
			for (int i = 0; i < mh_temp3length; i++)
			{
				if(i == mh_temp3length - 1)
					banMaHoa = banMaHoa + "" + y + "," +mh_temp3[i];
				else banMaHoa = banMaHoa + "" + y + "," + mh_temp3[i] + "-";
			}
			var plainbanMaHoaBytes = System.Text.Encoding.UTF8.GetBytes(banMaHoa);
			return System.Convert.ToBase64String(plainbanMaHoaBytes);
		}

		private bool KiemTra(string chuKyStr,string content)
		{
			// hash nội dung của bản cần check 
			var hashContentStr = HashSha256(content);
			int i ;
			try
			{
				var decodeChuKy = System.Convert.FromBase64String(chuKyStr);
				var chuKy = System.Text.Encoding.UTF8.GetString(decodeChuKy);
				string[] chuKyToArray = chuKy.Split('-');
				//cắt từng chuỗi mã hoá để so sánh
				for (i = 0; i < hashContentStr.Length; i++)
				{
					string[] kuTuMh = chuKyToArray[i].Split(',');
					long s1 = long.Parse(kuTuMh[0]);
					long s2 = long.Parse(kuTuMh[1]);
					long v1 = Modulo(a, (long)hashContentStr[i], p);
					long v2 = Modulo((Modulo(d, s1, p) * Modulo(s1, s2, p)), 1, p);
					if (v1 != v2) return false;
				}

			}
			catch
            {
				return false;
            }
			return true;
		}
	}
}
