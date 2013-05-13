using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using FurClient.BusinessClass;
using FurClient.Windows.FurService;

namespace FurClient
{
    public partial class FormMain : Form
    {
        private IDictionary<string, Installazione> _installazioni;

        public FormMain()
        {
            InitializeComponent();
            Setup();
        }

        private void Setup()
        {
            #region Combo mesi

            cbMese.Items.Clear();

            cbMese.Items.Add(new ItemCombo("01", "Gennaio"));
            cbMese.Items.Add(new ItemCombo("02", "Febbraio"));
            cbMese.Items.Add(new ItemCombo("03", "Marzo"));
            cbMese.Items.Add(new ItemCombo("04", "Aprile"));
            cbMese.Items.Add(new ItemCombo("05", "Maggio"));
            cbMese.Items.Add(new ItemCombo("06", "Giugno"));
            cbMese.Items.Add(new ItemCombo("07", "Luglio"));
            cbMese.Items.Add(new ItemCombo("08", "Agosto"));
            cbMese.Items.Add(new ItemCombo("09", "Settembre"));
            cbMese.Items.Add(new ItemCombo("10", "Ottobre"));
            cbMese.Items.Add(new ItemCombo("11", "Novembre"));
            cbMese.Items.Add(new ItemCombo("12", "Dicembre"));

            cbMese.SelectedIndex = -1;

            #endregion

            #region Combo anni

            cbAnno.Items.Clear();
            var currentYear = DateTime.Now.Year;
            for (int anno = currentYear; anno >= currentYear-2; anno--)
            {
                cbAnno.Items.Add(anno);
            }
            cbAnno.SelectedIndex = -1;

            #endregion

            #region Installazioni

            ReadXml();
            cbApplicazioni.Items.Clear();
            foreach (var installazione in _installazioni.OrderBy(i => i.Key))
            {
                cbApplicazioni.Items.Add(new ItemCombo(installazione.Value.Url, installazione.Key));
            }

            #endregion

            cbApplicazioni.Focus();
        }

        private void ReadXml()
        {
            _installazioni = new Dictionary<string, Installazione>();

            XDocument doc = XDocument.Load(@"..\..\Configuration.xml");

            foreach (var applicazione in doc.Elements("ConfigurazioneClientFur").Elements())
            {
                var installazione = new Installazione();
                installazione.Nome = applicazione.Element("Nome").Value;
                installazione.Url = applicazione.Element("Url").Value;

                var asl = new List<string>();
                foreach (var aslPresenti in applicazione.Elements("AslPresenti").Elements())
                {
                    asl.Add(aslPresenti.Value);
                }
                installazione.AslPresenti = asl;

                _installazioni.Add(installazione.Nome, installazione);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Controlli input

            if (string.IsNullOrEmpty(txUsername.Text))
            {
                MessageBox.Show("Inserire lo Username");
                return;
            }

            if (string.IsNullOrEmpty(txPin.Text))
            {
                MessageBox.Show("Inserire il Pin");
                return;
            }

            if (cbApplicazioni.SelectedIndex == -1)
            {
                MessageBox.Show("Selezionare un'installazione");
                return;
            }

            if (cbAsl.SelectedIndex == -1)
            {
                MessageBox.Show("Selezionare un'ASL");
                return;
            }

            if (cbMese.SelectedIndex == -1)
            {
                MessageBox.Show("Selezionare un mese");
                return;
            }

            if (cbAnno.SelectedIndex == -1)
            {
                MessageBox.Show("Selezionare un anno");
                return;
            }

            #endregion

            try
            {
                var service = new FurServiceClient();

                service.ClientCredentials.UserName.UserName = txUsername.Text;
                service.ClientCredentials.UserName.Password = txPin.Text;

                service.Endpoint.Address = new EndpointAddress(tbUrl.Text);

                var distinta = service.GetFUR(new FurRequest
                                                  {
                                                      Anno = cbAnno.Text,
                                                      CodiceAsl = cbAsl.Text,
                                                      CodiceFarmaciaASL = null,
                                                      Mese = (cbMese.SelectedItem as ItemCombo).Value
                                                  });
                
                tbFur.Text = stringSerializeObject(distinta);
                btnSalva.Enabled = true;
            }
            catch (Exception exception)
            {
                tbFur.Text = exception.Message;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbFur.Clear();
            btnSalva.Enabled = false;
        }

        private string stringSerializeObject(Object pObject)
        {
            try
            {
               
                var memoryStream = new MemoryStream();
                XmlSerializer xs = new XmlSerializer(typeof(Distinta));
                XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, new UTF8Encoding(false));
                xmlTextWriter.Formatting = Formatting.Indented;

                xs.Serialize(xmlTextWriter, pObject);
                memoryStream = (MemoryStream)xmlTextWriter.BaseStream;

                byte[] b = memoryStream.ToArray();
                string s = Encoding.UTF8.GetString(b);

                memoryStream.Flush();
                memoryStream.Close();

                return s;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        private void cbApplicazioni_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbUrl.Text = (cbApplicazioni.SelectedItem as ItemCombo).Value;
            cbAsl.SelectedIndex = -1;
            cbAsl.Items.Clear();

            var installazione = _installazioni[(cbApplicazioni.SelectedItem as ItemCombo).Text];

            foreach (var asl in installazione.AslPresenti)
            {
                cbAsl.Items.Add(asl);
            }
            cbAsl.SelectedIndex = -1;
            txPin.Text = txUsername.Text = string.Empty;
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "File XML|*.xml";
            saveFileDialog1.Title = "Salva FUR";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                try
                {
                    File.WriteAllText(saveFileDialog1.FileName, tbFur.Text); 
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                
            }
        }



    }
}
