namespace MinimalAPI;

public static class Api
{

    public static void ConfigureApi(this WebApplication app)
    {
        app.MapGet("/Users", GetUsers);
        app.MapGet("/Users/{id}", GetUser);
    }

    private static async Task<IResult> GetUsers(IUserData data)
    {
        try
        {
            return Results.Ok(await data.GetUsers());

        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message);
        }

    }

    private static async Task<IResult> GetUser(int id, IUserData data)
    {
        try
        {
            var result=await data.GetUser(id);
            if (result == null) return Results.NotFound();
            return Results.Ok(result);

        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message);
        }
    }
}
