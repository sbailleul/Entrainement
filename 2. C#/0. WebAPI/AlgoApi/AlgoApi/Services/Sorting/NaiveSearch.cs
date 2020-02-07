using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using AlgoApi.Models;

namespace TodoApi.Services.Reordering
{
    public class NaiveSearch: ISorter
    {
        private List<TagVector<string>> TagVectors { get; set; }
        
        public List<List<string>> sortMatrix(List<List<string>> matrix)
        {
            InitVectors(matrix);
            var switchCnt = 7000;

            while (GetError() > 0 && switchCnt >= 0)
            {
                
            }
            
            throw new System.NotImplementedException();
        }

        private void InitVectors(List<List<string>> matrix)
        {
            
            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    TagVectors.Add(new TagVector<string>(new List<int>{i,j}, matrix[i][j]));        
                }
            }
        }

        private double GetError()
        {
            var error = 0.0;
            foreach (var tagVector1 in TagVectors)
            {
                foreach (var tagVector2 in TagVectors)
                {
                    if (tagVector1.Tag == tagVector2.Tag && tagVector1.Pos[1] != tagVector2.Pos[2]) error++;
                }
            }
            return error;
        }

        private void SwapVector(List<int> pos1, List<int> pos2)
        {
            var tmpPos = pos1;
            pos1 = pos2;
            pos2 = tmpPos;
        }

        private bool AreNeighbours(List<int> pos1, List<int> pos2)
        {
            if (pos1 == null) throw new ArgumentNullException(nameof(pos1));
            if (pos2 == null) throw new ArgumentNullException(nameof(pos2));
            
            if(pos1[0] != pos2[0] && (pos1[1]-1 == pos2[1] || pos1[1]+1 == pos2[1] )){
                return true;
            } else if(pos1[1] != pos2[1] && ())
        }
        
    }
}