using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class IndexModel : PageModel
{
    private int currentPlayer = 1;
    private List<List<int>> board = new List<List<int>>();

    public IndexModel()
    {
        for (int row = 0; row < 6; row++)
        {
            board.Add(new List<int>());
            for (int col = 0; col < 7; col++)
            {
                board[row].Add(0);
            }
        }
    }

    public string GetButtonClass(int row, int col)
    {
        return board[row][col] == 1 ? "btn btn-primary btn-lg round-btn player-1" :
               board[row][col] == 2 ? "btn btn-primary btn-lg round-btn player-2" :
               "btn btn-primary btn-lg round-btn";
    }

    public void OnPostDropPiece(int row, int col)
    {
        if (board[row][col] == 0)
        {
            board[row][col] = currentPlayer;
            currentPlayer = (currentPlayer == 1) ? 2 : 1;
        }
    }
}
