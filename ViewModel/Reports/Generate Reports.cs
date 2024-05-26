using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using UserControl = System.Windows.Controls.UserControl;
using System.Windows.Forms;
using Font = iTextSharp.text.Font;
using iTextSharp.text.pdf.qrcode;
using Paragraph = iTextSharp.text.Paragraph;
using System.Data.SqlClient;
using System.Net.Mail;

namespace MidProjectA.ViewModel.Reports
{
    public partial class Generate_Reports : Form
    {
        Font boldFont =new Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN,16,iTextSharp.text.Font.BOLD);
        public Generate_Reports()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            studdentReport();

        }
        private Document AllStudents(ref Document doc)
        {
            try
            {
                doc.NewPage();

                // Creating a Paragraph with bold font
                Paragraph title = new Paragraph("All Students",boldFont);
                title.SpacingBefore = 28f;
                title.SpacingAfter = 20f;
                title.Font.Size = 20;
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Select S.RegistrationNo AS [Registration No], (FirstName + ' ' + LastName) AS Name,L.Value AS Gender,(SELECT FORMAT(DateOfBirth, 'dd-MM-yyyy')) AS [DoB],Contact,Email from Person P JOIN Student S ON S.Id=P.Id JOIN Lookup L ON L.Id=P.Gender", con);
                SqlDataReader reader = cmd.ExecuteReader();

                PdfPTable table = new PdfPTable(reader.FieldCount);
                table.WidthPercentage = 100;
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(reader.GetName(i)));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.BackgroundColor = new BaseColor(128, 128, 128);
                    table.AddCell(cell);
                }
                while (reader.Read())
                {
                    for(int i=0;i<reader.FieldCount;i++)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(reader[i].ToString()));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                    }
                }
                reader.Close();
                doc.Add(table);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return doc;
        }
        private void studdentReport()
        {
            SaveFileDialog dialog= new SaveFileDialog();
            dialog.Filter = "PDF(*.pdf)|*.pdf";
            dialog.FileName = "Students Enrolled";
            bool error = false;
            if(dialog.ShowDialog()== DialogResult.OK)
            {
                if(File.Exists(dialog.FileName))
                {
                    try
                    {
                        File.Delete(dialog.FileName);
                    }
                    catch(Exception e)
                    {
                        error= true;
                        MessageBox.Show("Enable to Save File");
                    }
                }
                if(!error)
                {
                    Document doc = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(dialog.FileName, FileMode.Create));
                    doc.Open();
                    doc = AllStudents(ref doc);
                    doc.Close();
                    writer.Close();
                }
            }
             
        }
        private Document Advisors(ref Document doc)
        {
            try
            {
                Paragraph title = new Paragraph("All Students", boldFont);
                title.SpacingBefore = 28f;
                title.SpacingAfter = 20f;
                title.Font.Size = 20;
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Select (FirstName + ' ' + LastName) AS Name, L1.Value AS Designation,A.Salary,L.Value AS Gender,(SELECT FORMAT(DateOfBirth, 'dd-MM-yyyy')) AS [DoB],Contact,Email from Person P JOIN Advisor A ON A.Id=P.Id JOIN Lookup L ON L.Id=P.Gender JOIN Lookup L1 ON L1.Id=A.Designation", con);
                SqlDataReader reader = cmd.ExecuteReader();

                PdfPTable table = new PdfPTable(reader.FieldCount);
                table.WidthPercentage = 100;
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(reader.GetName(i)));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.BackgroundColor = new BaseColor(128, 128, 128);
                    table.AddCell(cell);
                }
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(reader[i].ToString()));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                    }
                }
                reader.Close();
                doc.Add(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return doc;
        }
        private void AdvisorReport()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "PDF(*.pdf)|*.pdf";
            dialog.FileName = "Advisors Enrolled";
            bool error = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(dialog.FileName))
                {
                    try
                    {
                        File.Delete(dialog.FileName);
                    }
                    catch (Exception e)
                    {
                        error = true;
                        MessageBox.Show("Enable to Save File");
                    }
                }
                if (!error)
                {
                    Document doc = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(dialog.FileName, FileMode.Create));
                    doc.Open();
                    doc = Advisors(ref doc);
                    doc.Close();
                    writer.Close();
                }
            }

        }
        private void Generate_Reports_Load(object sender, EventArgs e)
        {
        }

        private void iconButtonAdd_Click(object sender, EventArgs e)
        {
            AdvisorReport();
        }
        private List<int> EvIds()
        {
            List<int>ids=new List<int>();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select id from evaluation order by id asc", con);
            SqlDataReader reader=cmd.ExecuteReader();
            while(reader.Read())
            {
                ids.Add(int.Parse(reader["id"].ToString()));
            }
            reader.Close();
            return ids;
        }
        private List<string> evTitle()
        {
            List<string> title = new List<string>();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select name from evaluation order by id asc", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                title.Add(reader["name"].ToString());
            }
            reader.Close();
            return title;
        }
        private Document markSheet(ref Document doc)
        {
            try
            {
                List<int> ids = EvIds();
                List<string> titles = evTitle();
                if (ids.Count > 0)
                {
                    string query = "";
                    int idx = 0;
                    foreach (int evid in ids)
                    {
                        query += ",Max(case when e.id=" + evid + " then ge.obtainedMarks end) as [" + titles[idx] + "]";
                        idx++;
                    }
                    doc.NewPage();
                    Paragraph title = new Paragraph("Mark Sheeet", boldFont);
                    title.SpacingBefore = 28f;
                    title.SpacingAfter = 20f;
                    title.Font.Size = 20;
                    title.Alignment = Element.ALIGN_CENTER;
                    doc.Add(title);
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("Select s.RegistrationNo AS [Registration No], (p.FirstName + ' ' + p.LastName) AS Name, Max(pr.title) as [Project Title] " + query + ", " +
                        "sum((ge.obtainedMarks*e.totalWeightage)/e.totalMarks) as [Total Marks] from " +
                        " groupevaluation ge join evaluation e on ge.evaluationid=e.id join groupstudent gs on gs.groupid=ge." +
                        "groupid join student s on s.id=gs.studentid " +
                        "join person p on p.id=s.id join groupproject gp on gp.groupid=ge.groupid join project pr on pr.id=" +
                        "gp.projectid where gs.status in (select id from lookup where value='Active') group by ge.GroupId,pr.Id,s.Id,s.RegistrationNo, p.firstname,p.lastname " +
                        "ORDER BY ge.GroupId,pr.Id,s.RegistrationNo;", con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    PdfPTable table = new PdfPTable(reader.FieldCount);
                    table.WidthPercentage = 100;
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(reader.GetName(i)));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.BackgroundColor = new BaseColor(128, 128, 128);
                        table.AddCell(cell);
                    }
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(reader[i].ToString()));
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            table.AddCell(cell);
                        }
                    }
                    reader.Close();
                    doc.Add(table);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return doc;
        }
        private void MarkSheetReport()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "PDF(*.pdf)|*.pdf";
            dialog.FileName = "MarkSheet";
            bool error = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(dialog.FileName))
                {
                    try
                    {
                        File.Delete(dialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        error = true;
                        MessageBox.Show("Enable to Save File");
                    }
                }
                if (!error)
                {
                    Document doc = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(dialog.FileName, FileMode.Create));
                    doc.Open();
                    doc = markSheet(ref doc);
                    doc.Close();
                    writer.Close();
                }
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            MarkSheetReport();
        }
        private Document Groups(ref Document doc)
        {
            try
            {
                doc.NewPage();

                // Creating a Paragraph with bold font
                Paragraph title = new Paragraph("Groups", boldFont);
                title.SpacingBefore = 28f;
                title.SpacingAfter = 20f;
                title.Font.Size = 20;
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT CONCAT('G-',G.Id) AS [Group],Pr.Title AS [Project],STRING_AGG((CASE WHEN L.Value='Active' THEN " +
                    "S.RegistrationNo ELSE CONCAT(S.RegistrationNo,'(In-Active)') END), CHAR(13)) AS [Students] FROM [Group] G JOIN GroupStudent GS ON G.Id=GS.GroupId " +
                    "JOIN GroupProject GP ON GP.GroupId=G.Id JOIN Project Pr ON Pr.Id=GP.ProjectId JOIN Student S ON S.Id=GS.StudentId JOIN Person P ON P.Id=" +
                    "S.Id JOIN Lookup L ON L.Id=GS.Status GROUP BY G.Id,Pr.Title ORDER BY G.Id ASC", con);
                SqlDataReader reader = cmd.ExecuteReader();

                PdfPTable table = new PdfPTable(reader.FieldCount);
                table.WidthPercentage = 100;
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(reader.GetName(i)));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.BackgroundColor = new BaseColor(128, 128, 128);
                    table.AddCell(cell);
                }
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(reader[i].ToString()));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                    }
                }
                reader.Close();
                doc.Add(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return doc;
        }
        private void groupReport()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "PDF(*.pdf)|*.pdf";
            dialog.FileName = "Group Details Report";
            bool error = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(dialog.FileName))
                {
                    try
                    {
                        File.Delete(dialog.FileName);
                    }
                    catch (Exception e)
                    {
                        error = true;
                        MessageBox.Show("Enable to Save File");
                    }
                }
                if (!error)
                {
                    Document doc = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(dialog.FileName, FileMode.Create));
                    doc.Open();
                    doc = Groups(ref doc);
                    doc.Close();
                    writer.Close();
                }
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            groupReport();
        }
        private  Document AdvisoryBoard(ref Document doc)
        {

            try
            {
                doc.NewPage();

                // Creating a Paragraph with bold font
                Paragraph title = new Paragraph("Project with Advisory Board", boldFont);
                title.SpacingBefore = 28f;
                title.SpacingAfter = 20f;
                title.Font.Size = 20;
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT MAX(P.Title) Title,MAX(P.Description) AS [Project Description], " +
                    "MAX(CASE WHEN L.Value='Main Advisor' THEN CONCAT(Person.FirstName,' ',Person.LastName) END) AS [Main Advisor], " +
                    "MAX(CASE WHEN L.Value='Co-Advisor' THEN CONCAT(Person.FirstName,' ',Person.LastName) END) AS [Co Advisor], " +
                    "MAX(CASE WHEN L.Value='Industry Advisor' THEN CONCAT(Person.FirstName,' ',Person.LastName) END) AS [Industry Advisor] FROM  ProjectAdvisor PA " +
                    "INNER JOIN Advisor A ON PA.AdvisorId = A.Id JOIN Project P ON P.Id=PA.ProjectId JOIN Person ON Person.Id=" +
                    "A.Id JOIN Lookup L ON L.Id=PA.AdvisorRole GROUP BY PA.ProjectId ", con);
                SqlDataReader reader = cmd.ExecuteReader();

                PdfPTable table = new PdfPTable(reader.FieldCount);
                table.WidthPercentage = 100;
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(reader.GetName(i)));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.BackgroundColor = new BaseColor(128, 128, 128);
                    table.AddCell(cell);
                }
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(reader[i].ToString()));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                    }
                }
                reader.Close();
                doc.Add(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return doc;
        }
        private void AdvisoryBoardReport()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "PDF(*.pdf)|*.pdf";
            dialog.FileName = "Project With AdvisoryBoard";
            bool error = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(dialog.FileName))
                {
                    try
                    {
                        File.Delete(dialog.FileName);
                    }
                    catch (Exception e)
                    {
                        error = true;
                        MessageBox.Show("Enable to Save File");
                    }
                }
                if (!error)
                {
                    Document doc = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(dialog.FileName, FileMode.Create));
                    doc.Open();
                    doc = AdvisoryBoard(ref doc);
                    doc.Close();
                    writer.Close();
                }
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            AdvisoryBoardReport();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
