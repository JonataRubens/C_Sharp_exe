namespace jogoDaVelha
{
    public partial class Form1 : Form
    {
        string[] texto = new string[9];
        int Xplayer = 0, Yplayer = 0, empates = 0, rodadas = 0;
        bool turno = true, jogo_final = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            int buttonIndex = btn.TabIndex;

            if (btn.Text == "" && jogo_final == false)
            {

                if (turno)
                {
                    btn.Text = "X";
                    texto[buttonIndex] = btn.Text;
                    rodadas++;
                    turno = !turno;
                    check(1);
                }
                else
                {
                    btn.Text = "O";
                    texto[buttonIndex] = btn.Text;
                    rodadas++;
                    turno = !turno;
                    check(2);
                }
            }
        }

        void check(int checkPlayer)
        {
            string suporte = "";

            if (checkPlayer == 1)
            {
                suporte = "X";
            }
            else
            {
                suporte = "O";
            }

            for (int horizontal = 0; horizontal < 8; horizontal += 3)
            {
                if (suporte == texto[horizontal])
                {
                    if (texto[horizontal] == texto[horizontal + 1] && texto[horizontal] == texto[horizontal + 2])
                    {
                        MessageBox.Show("Jogador 1 venceu");
                        return;
                    }
                }
            }

            for (int vertical = 0; vertical < 3; vertical++)
            {
                if (suporte == texto[vertical])
                {
                    if (texto[vertical] == texto[vertical + 3] && texto[vertical] == texto[vertical + 6])
                    {
                        MessageBox.Show($"Jogador 2 venceu");
                        return;
                    }
                }
            }


            if (texto[0] == suporte)
            {
                if(texto[0] == texto[4] && texto[0] == texto[8])
                {
                    MessageBox.Show($"diago");
                }
            }

        }
    }
}