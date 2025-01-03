namespace Othello
{
    /// <summary>
    /// セル操作クラス
    /// </summary>
    public class CellController
    {
        #region 定数
        
        /// <summary>
        /// セルの状態
        /// </summary>
        public enum CellCondition
        {
            NONE_PLACE,
            BLACK_PLACE,
            WHITE_PLACE
        }
        
        /// <summary>
        /// ボードの一辺のマス目
        /// </summary>
        public const int BOARD_SIZE = 8;

        /// <summary>
        /// セルの直径
        /// </summary>
        public const float CELL_SIZE = 1.0f;

        #endregion // 定数

        #region メンバ変数

        /// <summary>
        /// セル
        /// </summary>
        private CellCondition[,] m_cell_condition = new CellCondition[BOARD_SIZE, BOARD_SIZE];

        #endregion // メンバ変数

    }
}

