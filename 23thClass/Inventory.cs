public class Inventory {
 private Guitar[] guitars;
 public Inventory(Guitar[] guitars){
    this.guitars = guitars;
 }
public Guitar GetGuitar(string serialnumber){
    foreach(Guitar guitar in guitars){
        if(guitar.GetSerialNumber().Equals(serialnumber));
        return guitar;
    }
}
}