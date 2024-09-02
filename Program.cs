using Raylib_cs;

using static Raylib_cs.Raylib;

namespace HelloWorld;

class Program
{
    public static void Main()
    {
        InitWindow(800, 480, "Hello World");

        while (!WindowShouldClose())
        {
            BeginDrawing();
            ClearBackground(Color.White);

            DrawText("Hello, world 22!", 12, 12, 20, Color.Black);

            EndDrawing();
        }

        CloseWindow();
    }
}

// namespace HelloWorld;
//
// class Program
// {
//     public static void Main()
//     {
//         Raylib.InitWindow(800, 480, "Hello World");
//
//         while (!Raylib.WindowShouldClose())
//         {
//             Raylib.BeginDrawing();
//             Raylib.ClearBackground(Color.White);
//
//             Raylib.DrawText("Hello, world!", 12, 12, 20, Color.Black);
//
//             Raylib.EndDrawing();
//         }
//
//         Raylib.CloseWindow();
//     }
// }