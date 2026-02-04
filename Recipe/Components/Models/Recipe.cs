namespace Recipe.Components.Models;

public class Recipe
{
    private int id { get; set; }
    private string name { get; set; }
    private string description { get; set; }
    private string ingredients { get; set; }
    private string instructions { get; set; }

    private Recipe Opskrift1 = new Recipe(); 
    
    List<Recipe> recipes;

    

    
    // Index view method

    public Recipe Index()
    {
        for (int i =0; i > recipes.Count; i++ )
        {
            return recipes[i];
        }

        return Index();

    }
    
    //Create recipe
    
    public Recipe Create()
    {
        
        
        return new Recipe();
    }
    
    
    // image mehtod

    private void ImageLoader()
    {
        
    }
 
    
}