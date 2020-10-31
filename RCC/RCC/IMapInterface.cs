using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
namespace RCC
{
    public interface IMapInterface
    {
        View ReturnMapView(double mapX, double mapY);
    }
}
