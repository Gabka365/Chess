using Chess.Properties;

namespace Chess;

public partial class Form1 : Form
{

    //Team One
    private const int BoardSize = 8;
    private const int ButtonSize = 75;

    private readonly Button[,] chessButtons = new Button[BoardSize, BoardSize];



    private readonly FigureMover _figureMover;



    private readonly bool isWhiteTurn = true;

    public Form1()
    {
        _figureMover = new FigureMover(true);
        InitializeComponent();
        InitializeChessBoard();
    }

    private void SetFigures()
    {
        foreach (var figure in _figureMover.Figures)
        {
            chessButtons[figure.Position.X, figure.Position.Y].Tag = figure;
            chessButtons[figure.Position.X, figure.Position.Y].Image = figure.GetImage();
        }
    }

    private void SetTurnIcon()
    {
        if (_figureMover._isWhiteTurn)
        {
            pbTurnIcon.Image = Resources.Empty_White;
        }
        else
        {
            pbTurnIcon.Image = Resources.Empty_Black;
        }
    }

    private void SetImageToAvailablePositions(bool isFillCells)
    {
        foreach (var position in _figureMover.AvaliablePositions)
        {
            var figure = _figureMover.GetFigure(position);
            if (figure != null)
            {
                if (isFillCells)
                {
                    figure.isChoosen = true;
                }
                else
                {
                    figure.isChoosen = false;
                }

                chessButtons[position.X, position.Y].Image = figure.GetImage();
            }
            else if (isFillCells)
            {
                chessButtons[position.X, position.Y].Image = Properties.Resources.Empty_Green;
            }
            else
            {
                chessButtons[position.X, position.Y].Image = GetEmptyImage(new Point(position.X, position.Y));
            }
        }
    }

    private Image GetEmptyImage(Point point)
    {
        return (point.X + point.Y) % 2 == 0
            ? Properties.Resources.Empty_White
            : Properties.Resources.Empty_Black;
    }

    private void ClearCurrentCell(Point point)
    {
        chessButtons[point.X, point.Y].Image = GetEmptyImage(point);
    }


    private void InitializeChessBoard()
    {
        for (var y = 0; y < BoardSize; y++)
        {
            for (var x = 0; x < BoardSize; x++)
            {
                var button = Initializer.GetButton(ButtonSize, x, y, 150, 50);
                chessButtons[x, y] = button;
                Controls.Add(chessButtons[x, y]);
                chessButtons[x, y].Click += ChessButton_Click;
            }
        }
        SetFigures();
    }

    private void ChessButton_Click(object sender, EventArgs e)
    {
        var button = (Button)sender;

        if (button.Tag is Figure figure && figure.isWhite == _figureMover._isWhiteTurn)
        {
            _figureMover.ChooseFigure(figure);
            button.Image = figure.GetImage();
            SetImageToAvailablePositions(true);
        }
        else if (_figureMover._currentfigure != null)
        {
            var point = button.Tag is Figure ? ((Figure)button.Tag).Position : (Point)button.Tag;
            ClearCurrentCell(_figureMover._currentfigure.Position);
            _figureMover.Move(point);
            SetFigures();
            SetImageToAvailablePositions(false);
            SetTurnIcon();
        }
    }
}