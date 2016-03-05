using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRaces {
    class Greyhound {
        
        public int StartingPosition;    // PictureBox 的初始位置
        public int RacetrackLength;     // 跑道長度
        public PictureBox MyPictureBox = null;  // PictureBox 物件
        public int Location = 0;        // 在跑道上的位置
        public Random Randomizer;       // Rondom 實例

        /// <summary>
        /// Runs this instance.
        /// 假如賽犬贏得比賽就傳回 true
        /// </summary>
        /// <returns></returns>
        public bool Run() {
            // 隨機向前移動 0、1、2、3、或 4 個空格
            Randomizer = new Random();
            Location = Randomizer.Next(0,5);

            // 更新 PictureBox 在表單上的位置

            MyPictureBox.Left += Location;

            // MyPictureBox.Left = StartingPosition + Location;

            // 假如賽犬贏得比賽就傳回 true
            if (MyPictureBox.Left - StartingPosition >= RacetrackLength)
                return true;
            return false;
        }

        /// <summary>
        /// Takes the starting position.
        /// 將位置重設到起跑點
        /// </summary>
        public void TakeStartingPosition() {
            MyPictureBox.Left = StartingPosition;
            Location = 0;
        }
    }
}