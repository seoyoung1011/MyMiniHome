using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMiniHome
{
    public partial class StartForm : MetroFramework.Forms.MetroForm
    {
        public FirestoreDb db;
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            string path = Program._path;
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            db = FirestoreDb.Create(Program._firebaseDB);
        }

        private void mBTN_login_Click(object sender, EventArgs e)
        {
            string id = mtb_loginID.Text;
            string pass = mtb_loginPW.Text;

            if (id == "" || pass == "")
            {
                MessageBox.Show("아이디 또는 비밀번호에 공백이 있습니다.");
                return;
            }

            LoginManagement(id, pass);
        }
        private async void LoginManagement(string id, string pass)
        {
            bool idCheck = await FindMember(id, pass);
            if (idCheck)
            {
                MetroFramework.MetroMessageBox.Show(this, "로그인 되었습니다.");
                MessageBox.Show("로그인 되었습니다.");
            }
            else if (!idCheck)
            {
                MessageBox.Show("아이디 또는 비밀번호가 일치하지 않습니다.");
            }
        }
        async Task<bool> FindMember(string id, string pass)
        {
            Query query = db.Collection("Join").WhereEqualTo("id", id).WhereEqualTo("password", pass);
            QuerySnapshot snap = await query.GetSnapshotAsync();

            foreach (DocumentSnapshot ds in snap)
            {
                if (ds.Exists)
                {
                    return true;
                }
            }
            return false;
        }

        bool idCheak = true;
        private async void mBTN_overlap_Click(object sender, EventArgs e)
        {
            string id = mtb_joinID.Text;

            idCheak = await FindId(id);
            if (idCheak)
            {
                MessageBox.Show("이미 존재하는 ID입니다.");
            }
            else if (!idCheak)
            {
                MessageBox.Show("사용할 수 있는 ID입니다.");
            }
        }
        async Task<bool> FindId(string id)
        {
            Query query = db.Collection("Join").WhereEqualTo("id", id);
            QuerySnapshot snap = await query.GetSnapshotAsync();

            foreach (DocumentSnapshot docsnap in snap)
            {
                if (docsnap.Exists)
                {
                    return true;
                }
            }
            return false;
        }
        private void mBTN_join_Click(object sender, EventArgs e)
        {
            string name = mtb_joinNAME.Text;
            string id = mtb_joinID.Text;
            string pw = mtb_joinPW.Text;
            string pwOK = mtb_joinPWcheck.Text;

            if (name == "" || id == "" || pw == "" || pwOK == "")
            {
                MessageBox.Show("입력란에 공백이 있습니다.");
                return;
            }
            Management(name, id, pw, pwOK);
        }
        private void Management(string name, string id, string pw, string pwOK)
        {
            if (idCheak)
            {
                MessageBox.Show("ID 중복검사를 해주세요.");
                return;
            }
            if (pw != pwOK)
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.");
                return;
            }
            MessageBox.Show("회원가입이 완료되었습니다.");
            Join(name, id, pw);
            this.Close();
        }
        private void Join(string name, string id, string pw)
        {
            DocumentReference doc = db.Collection("Join").Document();
            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                {"name", name },
                {"id", id },
                {"password", pw }
            };
            doc.SetAsync(data);
        }
    }
}
