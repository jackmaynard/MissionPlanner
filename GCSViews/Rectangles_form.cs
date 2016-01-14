using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GMap.NET;

namespace MissionPlanner.GCSViews.UCR_Rectangles
{
    public partial class Rectangles_form : Form
    {
        public Rectangles_form()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            double lat1 = Double.Parse(textBox_latitude1.Text);
            double lon1 = Double.Parse(textBox_longitude1.Text);
            double lat2 = Double.Parse(textBox_latitude2.Text);
            double lon2 = Double.Parse(textBox_longitude2.Text);
            double lat3 = Double.Parse(textBox_latitude3.Text);
            double lon3 = Double.Parse(textBox_longitude3.Text);
            double lat4 = Double.Parse(textBox_latitude4.Text);
            double lon4 = Double.Parse(textBox_longitude4.Text);
            PointLatLng p1 = new PointLatLng(lat1, lon1);
            PointLatLng p2 = new PointLatLng(lat2, lon2);
            PointLatLng p3 = new PointLatLng(lat3, lon3);
            PointLatLng p4 = new PointLatLng(lat4, lon4);
            FlightPlanner.instance.polygongridmode = true;
            FlightPlanner.instance.drawnpolygon.Points.Add(p1);
            FlightPlanner.instance.drawnpolygon.Points.Add(p2);
            FlightPlanner.instance.drawnpolygon.Points.Add(p3);
            FlightPlanner.instance.drawnpolygon.Points.Add(p4);
            FlightPlanner.instance.drawnpolygonsoverlay.Polygons.Add(FlightPlanner.instance.drawnpolygon);


            /*List<PointLatLng> points = new List<PointLatLng>();
            PointLatLng p1 = new PointLatLng(lat1, lon1);
            PointLatLng p2 = new PointLatLng(lat2, lon2);
            PointLatLng p3 = new PointLatLng(lat3, lon3);
            PointLatLng p4 = new PointLatLng(lat4, lon4);
            points.Add(p1);
            points.Add(p2);
            points.Add(p3);
            points.Add(p4);
            GMap.NET.WindowsForms.GMapPolygon test = new GMap.NET.WindowsForms.GMapPolygon(points, "yolo");
            test.IsVisible = true;*/
        }
    }
}
