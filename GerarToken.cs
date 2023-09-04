using System;
namespace GerarToken{ 
public class GerarToken{

protected Guid ID  {get; set;}

public  void CriarToken(){

this.ID = Guid.NewGuid();

}
public override string ToString(){

            return $"ID: {ID}";
        
        
        }


    }
}