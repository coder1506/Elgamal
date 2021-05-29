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
		private string _selectedLocation = string.Empty;
		public static bool HasKeyAuto = false;
		public Form1()
        {
			InitializeComponent();
			//các ô input không được sửa trong quá trình tạo khoá
			fileCheck.Enabled = false;
			signature.Enabled = false;
			pathFile.Enabled = false;
		}

		private void DisableField()
        {
			atxt.Enabled = false;
			ptxt.Enabled = false;
			dtxt.Enabled = false;
			xtxt.Enabled = false;
			ktxt.Enabled = false;
			ytxt.Enabled = false;
		}
		private void EnableField()
		{
			atxt.Enabled = true;
			ptxt.Enabled = true;
			dtxt.Enabled = true;
			xtxt.Enabled = true;
			ktxt.Enabled = true;
			ytxt.Enabled = true;
		}
		/// <summary>
		/// tạo khoá tự động
		/// </summary>
		/// <returns>trả về true nếu khoá đã tạo thành công và ngược lại</returns>
		private bool AutoCreateKey()
		{
			a = x = d = k = 0;
			Random random = new Random();
			do
			{  //chọn ngẫu nhiên số alpha thoả mã lớn hoặc bằng hơn 2 và nhỏ hơn p và là số nguyên tố cùng nhau với p
				a = (long)random.Next(2, (int)p - 1);
			}
			while (!GCDLa1((long)a, (long)p));
			//chọn ngẫu nhiên khoá bí mật x thoả mã lớn hơn hoặc bằng 2 vào nhỏ hơn p - 1
			x = (long)random.Next(2, (int)p - 2);
			// d được tình bằn công thức d= a^x mod P
			d = Modulo(a, x, p);
			do
			{  //chọn ngẫu nhiên khoá k thoả mã lớn hoặc bằng 2 vào nhỏ hơn hoặc bằng p - 1 và là số nguyên tố cùng nhau với p - 1
				k = (long)random.Next(2, (int)p - 1);
			} while (!GCDLa1((long)k, (long)p - 1));

			// Tính Y = A^k mod p - Khóa công khai
			y = Modulo(a, k, p);

			return true;
		} //Tạo khóa tự động
		private bool CheckKey()
        {
			var pCheck = long.Parse(ptxt.Text);
			if (pCheck < 5) return false;
			var aCheck = long.Parse(atxt.Text);
			var xCheck = long.Parse(xtxt.Text);
			var kCheck = long.Parse(ktxt.Text);
			if ((aCheck > pCheck - 1 || aCheck < 2) || !GCDLa1(aCheck,pCheck)) return false;
			if (xCheck > pCheck - 2 || xCheck < 2) return false;
			if ((kCheck > pCheck - 2 || kCheck < 2) || !GCDLa1(kCheck, pCheck - 1)) return false;
			if (Modulo(aCheck, xCheck, pCheck) != long.Parse(dtxt.Text)) return false;
			if (Modulo(aCheck, kCheck, pCheck) != long.Parse(ytxt.Text)) return false;
			return true;
        }
		private bool CheckKeyNull()
		{
			if (atxt.Text == "" || ptxt.Text == "" || dtxt.Text == "" || xtxt.Text == "" || ktxt.Text == "" || ytxt.Text == "")
				return false;
			return true;
		}
		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
			//tìm file để lựa chọn
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
			//tìm file để lựa chọn
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
			// tạo lại khoá mới
            resetData();
            do
            {
				//chọn 1 số ngẫu nhiên thoả mã p là số nguyên tố
                p = SoNgauNhien();

            } while (!LaSNT(p));
            try
            {
				//tạo khoá tự động
                HasKeyAuto = AutoCreateKey();
            }
            catch
            {
				//thông báo cho người dùng khi có lỗi ngoại lệ
                MessageBox.Show("khoá chưa được tìm thấy xin vui lòng tìm lại", "error", MessageBoxButtons.OK);
            }
			DisableField();
			// gán giá trị vào các ô input trong chương trình
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
			HasKeyAuto = false;
			EnableField();
        }

		/// <summary>
		/// chọn một số ngẫu nhiên từ 5 đến 100000
		/// </summary>
		/// <returns>1 số</returns>
		private long SoNgauNhien()
		{
			//khởi tạo đối tượng random
			Random random = new Random();
			//chọn 1 số ngẫu nhiên
			long randomNumber = (long)random.Next(5, 100000);
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
		/// <summary>
		/// kiểm tra xem 2 số có phải số nguyên tố cùng nhau hay không (thoả mãn khi ước chung lớn nhất của 2 số là 1)
		/// </summary>
		/// <param name="a">số thứ nhất</param>
		/// <param name="b">số thứ hai</param>
		/// <returns>true hoặc false</returns>
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
		/// <summary>
		/// thực hiện ký
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void signingBtn_Click(object sender, EventArgs e)
        {
            if (!HasKeyAuto)
            {
				a = long.Parse(atxt.Text);
				p = long.Parse(ptxt.Text);
				d = long.Parse(dtxt.Text);
				x = long.Parse(xtxt.Text);
				k = long.Parse(ktxt.Text);
				y = long.Parse(ytxt.Text);
				if (!CheckKey()) { MessageBox.Show("Chữ ký không hợp lệ", "error", MessageBoxButtons.OK); return; }
			}
			//check xem người dùng đã chọn file để ký hay chưa
			if (pathFile.Text == "") { MessageBox.Show("Xin vui lòng chọn file để ký", "error", MessageBoxButtons.OK); return; }
			//check xem người dùng đã tạo ra khoá hay chưa
			if (!HasKeyAuto && !CheckKeyNull()) { MessageBox.Show("Xin vui lòng chọn khoá để ký", "error", MessageBoxButtons.OK); return; }
			DialogResult result = MessageBox.Show("Vui lòng chọn vị trí để lưu file chữ ký", "Thông báo", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
				//tìm vị trí để lưu chữ ký
				if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
				{
					_selectedLocation = folderBrowserDialog1.SelectedPath;
				}
			}
			else return;
			//nếu không vi phạm 2 điều trên thì bắt đầu ký thôi :))
			string content = File.ReadAllText(pathFile.Text);
			// nội dung ký sẽ được lưu trong ô chữ ký
			signature.Text = Ky(content);
			//tên file ký
			_selectedLocation += "\\chuky.sig";
			// tiện thể tạo ra 1 file với đường dẫn C:\Users\Duc\Desktop\chuky.sig.txt để lưu chữ ký luôn
			using (File.Create(_selectedLocation)) { }
			//ghi vào file chữ ký đã được tạo
			using (StreamWriter sw = new StreamWriter(_selectedLocation))
            {
				sw.WriteLine(Ky(content));
				MessageBox.Show("ký thành công !!! Chữ ký đã được lưu vào trong file chuky.sig", "success", MessageBoxButtons.OK);
			}
		}

        private void pathFile_TextChanged(object sender, EventArgs e)
        {
			
		}
		/// <summary>
		/// check xem nội dung của file có bị thay đổi hay không bằng chữ ký
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void checkSignatureBtn_Click(object sender, EventArgs e)
        {
			//Nếu chưa có file thì làm sao mà kiểm tra được đây :((
			if (fileCheck.Text == "") { MessageBox.Show("Xin vui lòng chọn file để kiểm tra", "error", MessageBoxButtons.OK); return; }
			// có file rồi thì bắt đầu kiểm tra thôi
			else {
				//trước tiên đọc file xem có gì nào
				string content = File.ReadAllText(fileCheck.Text);
				//à có mấy ký tự do định dang lấy thừa hở ... xoá nó đi :((
				string chuKy = File.ReadAllText(_selectedLocation);
				// chữ ký có khớp không nhỉ ???
				if (KiemTra(chuKy, content)) { 
					// có thì thông báo ra thôi
					MessageBox.Show("Văn bản không có gì thay đổi", "thông báo", MessageBoxButtons.OK); 
					return; 
				}
                else
                {
					//không thì cũng thế :((
					MessageBox.Show("văn bản đã được chỉnh sửa hoặc chữ ký không chính xác", "thông báo", MessageBoxButtons.OK); return;
				}
			}
		}

		/// <summary>
		/// tìm nghịch đảo modulo của 1 số
		/// </summary>
		/// <param name="n"></param>
		/// <param name="m"></param>
		/// <returns></returns>
		long NghichDaoModulo(long n, long m)
		{
			//chạy vòng lặp từ 1 đến m-1
			for (long i = 1; i < m; i++)
			{
				//nếu có 1 số nhỏ hơn m mà nhân với n chia co m dữ 1 thì trả về giá trị 
				if (((long) n* i) % m == 1) {
				return i;
			}
		}
		  return 0; // nếu không có trả về 0
		}

        private void label14_Click(object sender, EventArgs e)
        {

        }
		/// <summary>
		/// tìm modulo của 1 số
		/// </summary>
		/// <param name="Coso">cơ số</param>
		/// <param name="SoMu">số mũ</param>
		/// <param name="modulo">modulo</param>
		/// <returns></returns>
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
		/// <summary>
		/// hàm băm sha256
		/// </summary>
		/// <param name="chuoiVao">chuỗi để băm</param>
		/// <returns>trả về 1 chuỗi băm</returns>
		private string HashSha256(string chuoiVao)
        {
			using (SHA256 sha256Hash = SHA256.Create())
			{
				// chuyển chuỗi về dạng byte
				byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(chuoiVao));

				// chuyển dạng byte đó dang dạng chuỗi
				StringBuilder builder = new StringBuilder();
				for (int i = 0; i < bytes.Length; i++)
				{
					builder.Append(bytes[i].ToString("x2"));
				}
				return builder.ToString();
			}
		}
		/// <summary>
		/// thưc hiện ký nên văn bản 
		/// </summary>
		/// <param name="ChuoiVao">chuỗi cần ký</param>
		/// <returns>trả về 1 chuỗi sau khi được ký</returns>
		private string Ky(string ChuoiVao)
		{
			//danh so ky tu unicode
			string hashStr = HashSha256(ChuoiVao);
			//lấy ra số lượng ký tự có trong hashStr
			int n = hashStr.Length;
			// khởi tạo một mảng để lưu ký tự dưới dạng long
			List<long> mh_temp2 = new List<long>();
			for (int i = 0; i < n; i++)
			{
				mh_temp2.Add((long)hashStr[i]);
			}
			//tạo mảng để lưu các giá trị đã được mã hoá thông qua công thức y2= (H(m) - x * y) * k^-1 * mod (p - 1)
			long mh_temp2length = mh_temp2.Count;
			List<long> mh_temp3 = new List<long>();

			//tính y2= (H(m) - x * y) * k^-1 * mod (p - 1)
			for (int i = 0; i < mh_temp2length; i++)
			{
				var s1 = ((mh_temp2[i] - x * y) % (p - 1)) < 0 ? ((mh_temp2[i] - x * y) % (p - 1)) + (p - 1) : ((mh_temp2[i] - x * y) % (p - 1));
				var s2 = NghichDaoModulo(k, p - 1);
				mh_temp3.Add(Modulo((long)s1*s2,1,p-1));
			}
			//lưu lại giá trị mã hoá cả y1 và y2
			String banMaHoa = string.Empty;
			long mh_temp3length = mh_temp3.Count;
			for (int i = 0; i < mh_temp3length; i++)
			{
				if(i == mh_temp3length - 1)
					banMaHoa = banMaHoa + "" + y + "," +mh_temp3[i];
				else banMaHoa = banMaHoa + "" + y + "," + mh_temp3[i] + "-";
			}
			//chuyển về dạng base64
			var plainbanMaHoaBytes = System.Text.Encoding.UTF8.GetBytes(banMaHoa);
			return System.Convert.ToBase64String(plainbanMaHoaBytes);
		}
		/// <summary>
		/// kiểm tra xem nội dụng đó của file đã bị thay đổi hay chưa
		/// </summary>
		/// <param name="chuKyStr">chữ ký đã được ký</param>
		/// <param name="content">Nội dung của văn bản cần được kiểm tra</param>
		/// <returns>trả về true hoặc false</returns>
		private bool KiemTra(string chuKyStr,string content)
		{
			// hash nội dung của bản cần check 
			var hashContentStr = HashSha256(content);
			int i ;
			try
			{
				// dịch ngược lại từ dạng base 64
				var decodeChuKy = System.Convert.FromBase64String(chuKyStr);
				var chuKy = System.Text.Encoding.UTF8.GetString(decodeChuKy);
				//cắt từng chuỗi mã hoá để so sánh
				string[] chuKyToArray = chuKy.Split('-');
				for (i = 0; i < hashContentStr.Length; i++)
				{
					string[] kuTuMh = chuKyToArray[i].Split(',');
					//chuỗi mã hoá s1
					long s1 = long.Parse(kuTuMh[0]);
					//chuỗi mã hoá s2
					long s2 = long.Parse(kuTuMh[1]);
					//giá trị của v1 là giá trị được tạo ra từ nội dung cần kiểm tra
					long v1 = Modulo(a, (long)hashContentStr[i], p);
					//giá trị của v2 là giá trị được tạo ra từ chữ ký của nội dung đó
					long v2 = Modulo((Modulo(d, s1, p) * Modulo(s1, s2, p)), 1, p);
					//chỉ cần 1 trường hợp không khớp sẽ trả về false
					if (v1 != v2) return false;
				}

			}
			catch
            {
				//nếu chữ ký bị thay đổi thì base64 sẽ không đọc được
				return false;
            }
			return true;
		}
	}
}
