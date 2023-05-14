using Countries.Model;
using Countries.Model.Country;

namespace Countries
{
    public partial class Form1 : Form
    {
        private const int MIN_NUMBER = 2;
        private const int MAX_NUMBER = 10;

        private Controller controller = new();

        public Form1()
        {
            InitializeComponent();
            foreach (var item in Data.ContinentCodeMap)
                continentComboBox.Items.Add(item.Key);
        }

        private void Confirm(object sender, EventArgs e)
        {
            wrongInputLabel.Visible = !ValidateText();
            emptyComboBoxLabel.Visible = continentComboBox.Text == "";
            if (wrongInputLabel.Visible || emptyComboBoxLabel.Visible)
                return;

            countriesTreeView.Nodes.Clear();
            noInformationLabel.Visible = false;
            pendingLabel.Visible = true;
            queryBackgroundWorker.RunWorkerAsync();
        }

        private void PerformQuery(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            string continentCode = "";

            Invoke(new Action(() => continentCode = Data.ContinentCodeMap[continentComboBox.Text]));

            List<Country> countries = null;
            try
            {
                countries = controller.GetRandomCountries(continentCode, int.Parse(nOfCountriesTextBox.Text));
                countries.Sort((a, b) => a.Name.CompareTo(b.Name));
            }
            catch (Exception ex)
            {
                Invoke(new Action(() =>
                {
                    pendingLabel.Visible = false;
                    noInformationLabel.Visible = true;
                }));
                return;
            }

            Invoke(new Action(() =>
            {
                foreach (Country country in countries)
                    AddCountryToTreeView(country);
                pendingLabel.Visible = false;
            }));
        }

        private bool ValidateText()
        {
            int n;
            try
            {
                n = int.Parse(nOfCountriesTextBox.Text);
            }
            catch (FormatException)
            {
                return false;
            }
            return n >= MIN_NUMBER && n <= MAX_NUMBER;
        }

        private void AddCountryToTreeView(Country country)
        {
            TreeNode node = new(country.Name);
            foreach (var property in typeof(Country).GetProperties())
            {
                if (property.Name == "Name")
                    continue;

                TreeNode child = new(property.Name);
                if (property.PropertyType == typeof(List<string>))
                {
                    if ((property.GetValue(country) as List<string>).Count == 0)
                        child.Nodes.Add(noInformationLabel.Text);
                    else
                        foreach (string s in property.GetValue(country) as List<string>)
                            child.Nodes.Add(s);
                }
                else if (property.GetValue(country) is null)
                    child.Nodes.Add(noInformationLabel.Text);
                else
                    child.Nodes.Add(property.GetValue(country).ToString());

                node.Nodes.Add(child);
            }
            countriesTreeView.Nodes.Add(node);
        }
    }
}