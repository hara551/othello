using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Othello{

/// <summary>
/// ボード管理
/// </summary>
public class BoardManager : MonoBehaviour
{
    #region メンバ変数

    /// <summary>
    /// マスのプレハブ
    /// </summary>
    [SerializeField] private GameObject cellPrefab;

    /// <summary>
    /// セル操作クラス
    /// </summary>
    private CellController m_cell_controller = null;
    
    #endregion // メンバ変数
    
    /// <summary>
    /// 初期化処理
    /// </summary>
    private void Start()
    {
        m_cell_controller = new CellController();
        
        CreateBoard();
    }
    
    /// <summary>
    /// ボードを作成
    /// </summary>
    private void CreateBoard()
    {
        int board_size = CellController.BOARD_SIZE;
        float cell_size = CellController.CELL_SIZE;
        
        // ボードの中央位置を(0,0,0)にするためのオフセットを計算
        float offset = cell_size * board_size / 2;
        
        for (int i = 0; i < board_size; i++)
        {
            for (int j = 0; j < board_size; j++)
            {
                // マス目に対応した位置にセルを配置
                Vector3 cell_position = new Vector3(i * cell_size - offset, 0, j * cell_size - offset);
                GameObject cell_object = Instantiate(cellPrefab, cell_position, Quaternion.identity);
                // 位置に応じて名前を設定
                cell_object.name = "Cell_" + i + "_" + j;
            }
        }
    }
}
}