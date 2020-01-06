using System.Collections.Generic;

namespace TodoApi.Services.Reordering
{
    public interface ISorter
    {
        List<List<string>> sortMatrix(List<List<string>> matrix);
    }
}