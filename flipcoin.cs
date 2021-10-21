using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flipcoin
{
    public partial class Program : Program
    {
        //array of Coins
        Coin[] Coins = new Coin[5];
        public Program()
        {
            InitializeComponent();
        }


        private void button1_click(object sender, EventArgs e)
        private void button1_click(object sender,EventArgs e) 
        {
            Coins[0] = new Coin(true);
            Coins[1] = new Coin(true);
            Coins[2] = new Coin(true);
            Coins[3] = new Coin(true);
            Coins[0] = new Coin(true);
            //Coins[5] = new Coins(true);

        }
    }
}
