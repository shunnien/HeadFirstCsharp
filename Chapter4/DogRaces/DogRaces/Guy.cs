using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRaces {
    class Guy {
        public string Name;     // 人名
        public Bet MyBet;       // 代表下注金額的 Bet 實例
        public int Cash;        // 還有多少現金

        // 最後兩個欄位是玩家在表單上的 GUI 控制
        public RadioButton MyRadioButton;   // 圖形選鈕
        public Label MyLabel;   // 標籤

        /// <summary>
        /// Updates the labels.
        /// 設定關於下注金額之描述的標籤
        /// 設定顯示現金餘額之圓形選鈕旁的標籤
        /// </summary>
        public void UpdateLabels() {
            MyRadioButton.Text = Name + " has " + Cash + " bucks";
            if (MyBet == null) {
                MyLabel.Text = String.Format("{0} hasn't placed any bets", Name);
            }
            else {
                MyLabel.Text = MyBet.GetDescription();
            }
        }

        /// <summary>
        /// Clears the bet.
        /// 下注金額重設為 0
        /// </summary>
        public void ClearBet() {
            MyBet.Amount = 0;
        }

        /// <summary>
        /// Places the bet.
        /// 下注並將下注金額存放在 Mybet 欄位
        /// 如果玩家有足夠現金可下注就傳回 true
        /// </summary>
        /// <param name="BetAmount">The bet amount.</param>
        /// <param name="DogToWin">The dog to win.</param>
        /// <returns></returns>
        public bool PlaceBet(int BetAmount, int DogToWin) {
            if (BetAmount <= Cash) {
                MyBet = new Bet() {
                    Amount= BetAmount,
                    Dog = DogToWin,
                    Bettor = this
                };
                return true;
            }
            return false;
        }

        public void Collect(int winner) {
            Cash += MyBet.PayOut(winner);
        }
    }
}
