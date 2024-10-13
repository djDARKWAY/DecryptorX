using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecryptorX
{
    public partial class Form1 : Form
    {
        private HashSet<string> dictionaryPT;
        private HashSet<string> dictionaryEN;

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private int heightStep;
        private int targetWidth;

        private int previousIndex = -1;

        private NotifyIcon notification;

        Color mainColor = Color.Gold;
        Color secondaryColor = Color.Black;

        public Form1()
        {
            InitializeComponent();

            // Windows
            this.Size = new Size(340,428);

            // GroupBoxes
            gbxMorse.Location = new Point(16, 70);

            // ComboBoxes
            cboCipher.SelectedItem = "Caesar Cipher";

            // DataGridView
            dgvCeaserResults.DefaultCellStyle.Font = new Font("Consolas", 9);
            dgvCeaserResults.ColumnHeadersDefaultCellStyle.Font = new Font("Consolas", 10);
            dgvCeaserResults.GridColor = ColorTranslator.FromHtml("#78620A");
            dgvCeaserResults.Columns[0].HeaderText = "→";
            dgvCeaserResults.Columns[0].DefaultCellStyle.Font = new Font("Consolas", 16);
            dgvCeaserResults.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Animations
            heightStep = 20;
            targetWidth = 428;

            // Notification
            notification = new NotifyIcon { Icon = SystemIcons.Information, Visible = true };
        }

        // --- CIPHER: CAESAR --------------------------------------------------------------------------------------------------------
        private void LoadDictionaries()
        {
            string filePathEN = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "wordlists", "wordlistEN.txt");
            string filePathPT = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "wordlists", "wordlistPT.txt");

            dictionaryEN = new HashSet<string>(File.ReadAllLines(filePathEN).Select(line => line.Trim().ToLower()));
            dictionaryPT = new HashSet<string>(File.ReadAllLines(filePathPT).Select(line => line.Trim().ToLower()));
        }
        private string DecryptCesar(string encryptedText, int shift)
        {
            return new string(encryptedText.Select(c =>
                char.IsLetter(c) ? (char)(((c - (char.IsUpper(c) ? 'A' : 'a') + shift) % 26 + 26) % 26 + (char.IsUpper(c) ? 'A' : 'a')) : c).ToArray());
        }
        private void btnDecryptCaesar_Click(object sender, EventArgs e)
        {
            // Load dictionaries
            LoadDictionaries();

            var encryptedText = txtMessageCaesar.Text;
            var possibleMessages = Enumerable.Range(1, 25)
                .Select(shift => new
                {
                    Shift = shift,
                    DecryptedText = DecryptCesar(encryptedText, shift)
                })
                .ToList();

            // Clear previous results
            dgvCeaserResults.Rows.Clear();
            foreach (var message in possibleMessages)
            {
                dgvCeaserResults.Rows.Add(message.Shift, message.DecryptedText);
            }

            string bestMessage = null;
            int bestMatchPT = 0;
            int bestMatchEN = 0;
            string detectedLanguage = "-";

            // Detect the correct message and count word matches for each language
            foreach (var possibleMessage in possibleMessages)
            {
                var message = possibleMessage.DecryptedText;

                // Split the message into words
                var words = new string(message.Where(c => char.IsLetter(c) || char.IsWhiteSpace(c)).ToArray())
                    .ToLower()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                // Count words in PT and EN dictionaries
                int matchPT = words.Count(word => dictionaryPT.Contains(word));
                int matchEN = words.Count(word => dictionaryEN.Contains(word));

                // Update best match based on word count, with priority given to the language with the most matches
                if (matchPT > bestMatchPT || (matchPT == bestMatchPT && matchEN > bestMatchEN))
                {
                    bestMessage = message;
                    bestMatchPT = matchPT;
                    bestMatchEN = matchEN;

                    detectedLanguage = bestMatchEN > bestMatchPT ? "English" : "Portuguese";
                }
            }

            // Move the best message to the top
            var bestRow = dgvCeaserResults.Rows.Cast<DataGridViewRow>()
                .FirstOrDefault(row => row.Cells[1].Value.ToString() == bestMessage);

            if (bestRow != null)
            {
                dgvCeaserResults.Rows.Remove(bestRow);
                dgvCeaserResults.Rows.Insert(0, bestRow);
                bestRow.DefaultCellStyle.BackColor = Color.Gold;
                dgvCeaserResults.CurrentCell = null;
            }

            txtLanguageCeasar.Text = detectedLanguage;
        }

        // --- CIPHER: MORSE --------------------------------------------------------------------------------------------------------
        private readonly Dictionary<string, char> morseToChar = new Dictionary<string, char>
        {
            { ".-", 'A' }, { "-...", 'B' }, { "-.-.", 'C' }, { "-..", 'D' }, { ".", 'E' },
            { "..-.", 'F' }, { "--.", 'G' }, { "....", 'H' }, { "..", 'I' }, { ".---", 'J' },
            { "-.-", 'K' }, { ".-..", 'L' }, { "--", 'M' }, { "-.", 'N' }, { "---", 'O' },
            { ".--.", 'P' }, { "--.-", 'Q' }, { ".-.", 'R' }, { "...", 'S' }, { "-", 'T' },
            { "..-", 'U' }, { "...-", 'V' }, { ".--", 'W' }, { "-..-", 'X' }, { "-.--", 'Y' },
            { "--..", 'Z' }, { "-----", '0' }, { ".----", '1' }, { "..---", '2' }, { "...--", '3' },
            { "....-", '4' }, { ".....", '5' }, { "-....", '6' }, { "--...", '7' }, { "---..", '8' },
            { "----.", '9' }, { " / ", ' ' }
        };
        private void txtMessageMorse_TextChanged(object sender, EventArgs e)
        {
            UpdateMorseDecoding();
        }
        private void txtMorseS_TextChanged(object sender, EventArgs e)
        {
            UpdateMorseDecoding();
        }
        private void txtMorseL_TextChanged(object sender, EventArgs e)
        {
            UpdateMorseDecoding();
        }
        private void txtMorseE_TextChanged(object sender, EventArgs e)
        {
            UpdateMorseDecoding();
        }
        private void UpdateMorseDecoding()
        {
            try
            {
                string shortSignal = txtMorseS.Text.Trim();
                string longSignal = txtMorseL.Text.Trim();
                string spaceSignal = txtMorseE.Text.Trim();

                string morseCode = txtMessageMorse.Text.Trim();

                morseCode = morseCode
                        .Replace(shortSignal, ".")
                        .Replace(longSignal, "-")
                        .Replace(spaceSignal, " / ")
                        .Trim()
                        .Replace("   ", " / ");

                var words = morseCode.Split(new[] { " / " }, StringSplitOptions.None);
                var decodedWords = words.Select(word =>
                    string.Concat(
                        word.Split(' ').Select(code =>
                            morseToChar.TryGetValue(code, out char c) ? c.ToString() : ""
                        )
                    )
                );

                string decodedMessage = string.Join(" ", decodedWords).Trim();
                txtMorseResult.Text = decodedMessage;

                lblMorseI.Visible = false;
            }
            catch
            {
                txtMorseResult.Text = string.Empty;
                lblMorseI.Visible = true;
            }
        }


        // --- WINDOW CONTROLLERS ----------------------------------------------------------------------------------------------------
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void panelToolbar_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void panelToolbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }
        private void panelToolbar_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }
        private void dgvCeaserResults_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string cellValue = dgvCeaserResults.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            Clipboard.SetText(cellValue);

            notification.BalloonTipTitle = "Copied to clipboard!";
            notification.BalloonTipText = cellValue;
            notification.BalloonTipIcon = ToolTipIcon.Info;
            notification.ShowBalloonTip(1000);
        }
        private void timerSize_Tick(object sender, EventArgs e)
        {
            if (this.Height < targetWidth)
            {
                this.Height = Math.Min(this.Height + heightStep, targetWidth);
                if (this.Height == targetWidth)
                    timerSize.Stop();
            }
            else if (this.Height > targetWidth)
            {
                this.Height = Math.Max(this.Height - heightStep, targetWidth);
                if (this.Height == targetWidth)
                    timerSize.Stop();
            }
        }
        private void HideAllGroupBoxes()
        {
            this.Controls.OfType<GroupBox>().ToList().ForEach(g => g.Visible = false);
        }
        // --- COLORS CONTROLLERS ----------------------------------------------------------------------------------------------------
        private void cboCipher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCipher.SelectedIndex == previousIndex)
                return;
            previousIndex = cboCipher.SelectedIndex;

            HideAllGroupBoxes();

            switch (cboCipher.SelectedIndex)
            {
                case 0:
                    mainColor = Color.Gold; secondaryColor = Color.Black;
                    gbxCaesar.Visible = true;
                    break;

                case 1:
                    mainColor = Color.LightGray; secondaryColor = Color.Black;
                    gbxMorse.Visible = true;
                    break;
            }

            this.Height = 76;
            timerSize.Start();

            // Mais colors
            var panels = new[] { panelB, panelL, panelR, panelToolbar };
            foreach (var panel in panels)
            {
                panel.BackColor = mainColor;
            }
            cboCipher.ForeColor = lblCipher.ForeColor = mainColor;
            lblTitle.ForeColor = secondaryColor;
        }
    }
}