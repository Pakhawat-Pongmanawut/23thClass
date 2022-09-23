public class Guitar {
  private double price ;
  private string builder ;
  private string serialnumber ;
  private string model ;
  private string woods;

  public Guitar(string serialnumber,
                double price,
                string builder,
                string model,
                string woods){
                    this.serialnumber = serialnumber;
                    this.price = price;
                    this.builder = builder;
                    this.model = model;
                    this.woods = woods;
                }
    public string GetSerialNumber()
    {
        return this.serialnumber;
    }

    public double GetPrice()
    {
        return this.price;
    }
    public string GetModel()
    {
        return this.model;
    }
    public string GetBuilder()
    {
        return this.builder;
    }
}