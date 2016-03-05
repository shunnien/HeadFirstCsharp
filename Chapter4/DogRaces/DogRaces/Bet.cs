using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogRaces {
    class Bet {
        public int Amount;  // 要求 MyBet 收付款
        public int Dog;     // 押哪一隻賽犬
        public Guy Bettor;  // 下注者

        public string GetDescription() {
            string description = "";
            if (Amount > 0) {
                description = string.Format("{0} bets {1} on dog #{2}", Bettor.Name, Amount, Dog);
            } else {
                description = string.Format("{0} hasn't placed a bet", Bettor.Name);
            }
            return description;
        }

        /// <summary>
        /// Pays the out.
        /// 參數 winner 代表贏得比賽的賽犬
        /// 假如押注的賽犬贏了，傳回等量的下注金額
        /// 否則，傳回負值的下注金額
        /// </summary>
        /// <param name="winner">The winner.</param>
        /// <returns></returns>
        public int PayOut(int winner) {
            if (Dog == winner) {
                return Amount;
            }
            return -Amount;
        }
    }
}
