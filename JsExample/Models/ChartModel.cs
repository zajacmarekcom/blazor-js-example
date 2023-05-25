namespace JsExample.Models;

public class ChartModel
{
    public string Type { get; set; }
    public ChartData Data { get; set; }
}

public class ChartData
{
    public string[] Labels { get; set; }
    public ChartDataset[] Datasets { get; set; }
}

public class ChartDataset
{
    public string Label { get; set; }
    public double[] Data { get; set; }
    public string BorderWidth { get; set; }
}