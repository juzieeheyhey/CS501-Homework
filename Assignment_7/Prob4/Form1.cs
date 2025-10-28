using GTranslate;
using GTranslate.Translators;

namespace Prob4
{
    public partial class Form1 : Form
    {
        private readonly GoogleTranslator _translator = new GoogleTranslator();
        public Form1()
        {
            InitializeComponent();

            cbLanguageSelect.SelectedIndex = 0; // Default to first language
        }

        private async void btnTranslate_Click(object sender, EventArgs e)
        {
            try
            {
                string inputText = tbUserInput.Text.Trim();
                if (string.IsNullOrEmpty(inputText))
                {
                    MessageBox.Show("Please enter text to translate.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string selectedLanguage = cbLanguageSelect.SelectedItem.ToString().ToLower();

                // Map selected language to language code
                string targetLangCode = selectedLanguage switch
                {
                    "spanish" => "es",
                    "french" => "fr",
                    "portuguese" => "pt",
                    _ => "en"
                };

                // Perform translation
                var result = await _translator.TranslateAsync(inputText, targetLangCode);

                lbUserOutput.Text = result.Translation;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during translation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
