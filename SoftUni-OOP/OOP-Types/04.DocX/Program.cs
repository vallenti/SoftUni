using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Novacode;
using System.Drawing;
using System.Diagnostics;

namespace _04.WordDocs
{
    class Program
    {
        static void Main(string[] args)
        {
            const int DefaultFontSize = 12;
            string fileName = "../../SoftUniGameContest.docx";
            using (DocX doc = DocX.Create(fileName))
            {
                #region Title
                Paragraph title = doc.InsertParagraph();
                title.AppendLine("SoftUni OOP Game Contest").Bold().FontSize(30);
                title.Alignment = Alignment.center;
                #endregion

                #region Image
                Novacode.Image imageGame = doc.AddImage("../../rpg-game.png");
                Paragraph pictureParagraph = doc.InsertParagraph("", false);
                Picture game = imageGame.CreatePicture(250, 600);
                pictureParagraph.InsertPicture(game);
                #endregion

                #region Info Text
                Paragraph text = doc.InsertParagraph();
                text.FontSize(13);
                text.AppendLine();
                text.Append("SoftUni is organizing a contest for the best ").FontSize(DefaultFontSize);
                text.Append("role playing game").Bold().FontSize(DefaultFontSize);
                text.Append(" from the OOP teamwork\r\n projects. The winning teams will receive a ").FontSize(DefaultFontSize);
                text.Append("grand prize").Bold().UnderlineStyle(UnderlineStyle.singleLine).FontSize(DefaultFontSize);
                text.Append("!\r\nThe game should be:").FontSize(DefaultFontSize);
                #endregion

                #region List of options
                List bullets = doc.AddList(null, 0, ListItemType.Bulleted);
                doc.AddListItem(bullets, "Properly structured and follow all good OOP practices");
                doc.AddListItem(bullets, "Awesome");
                doc.AddListItem(bullets, "..Very Awesome");
                doc.InsertList(bullets);
                doc.InsertParagraph(Environment.NewLine);
                #endregion

                #region Table
                Table table = doc.AddTable(4, 3);


                table.Alignment = Alignment.center;

                table.Rows[0].Cells[0].Paragraphs.First().Append("Team").Bold().Color(Color.White);
                table.Rows[0].Cells[0].Paragraphs.First().Alignment = Alignment.center;
                table.Rows[0].Cells[0].FillColor = Color.CornflowerBlue;
                table.Rows[0].Cells[1].Paragraphs.First().Append("Game").Bold().Color(Color.White);
                table.Rows[0].Cells[1].Paragraphs.First().Alignment = Alignment.center;
                table.Rows[0].Cells[1].FillColor = Color.CornflowerBlue;
                table.Rows[0].Cells[2].Paragraphs.First().Append("Points").Bold().Color(Color.White);
                table.Rows[0].Cells[2].Paragraphs.First().Alignment = Alignment.center;
                table.Rows[0].Cells[2].FillColor = Color.CornflowerBlue;

                for (int i = 1; i < 4; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        table.Rows[i].Cells[j].Paragraphs.First().Append("-");
                        table.Rows[i].Cells[j].Paragraphs.First().Alignment = Alignment.center;
                    }
                }

                table.Rows[0].Cells.ForEach(c => c.Width = 300);
                table.Rows[1].Cells.ForEach(c => c.Width = 300);
                table.Rows[2].Cells.ForEach(c => c.Width = 300);
                doc.InsertTable(table);
                #endregion

                #region Prize Info Text
                Paragraph lastText = doc.InsertParagraph();
                lastText.AppendLine();
                lastText.Append("The top 3 teams will receive a ").FontSize(DefaultFontSize);
                lastText.Append("SPECTACULAR").Bold().FontSize(13);
                lastText.Append(" prize:"+Environment.NewLine).FontSize(DefaultFontSize);
                lastText.Append("A HANDSHAKE FROM NAKOV")
                    .Bold()
                    .UnderlineStyle(UnderlineStyle.thick).FontSize(17)
                    .Color(Color.MidnightBlue);
                lastText.Alignment = Alignment.center;

                #endregion


                doc.Save();
            }

            // Open in Word:
            Process.Start("WINWORD.EXE", fileName);
        }
    }
}
