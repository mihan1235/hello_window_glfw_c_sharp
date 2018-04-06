using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_window
{
    using static glfw3;

    class Program
    {
        static int Main(string[] args)
        {
            glfwInit();
            glfwWindowHint(GLFW_CONTEXT_VERSION_MAJOR, 3);
            glfwWindowHint(GLFW_CONTEXT_VERSION_MINOR, 3);
            glfwWindowHint(GLFW_OPENGL_PROFILE, GLFW_OPENGL_CORE_PROFILE);
            SWIGTYPE_p_GLFWwindow window = glfwCreateWindow(800, 600, "LearnOpenGL", null, null);
            if (window == null)
            {
                Console.WriteLine("Failed to create GLFW window");
                glfwTerminate();
                return -1;
            }
            glfwMakeContextCurrent(window);
            //SWIGTYPE_p_f_p_struct_GLFWwindow_int_int__void point_f = framebuffer_size_callback;
            //glfwSetFramebufferSizeCallback(window,);
            // render loop
            // -----------
            while (glfwWindowShouldClose(window)!= to_int(true))
            {
                // input
                // -----
                processInput(window);

                // glfw: swap buffers and poll IO events (keys pressed/released, mouse moved etc.)
                // -------------------------------------------------------------------------------
                glfwSwapBuffers(window);
                glfwPollEvents();
            }
            glfwTerminate();
            return 0;
        }

        static void processInput(SWIGTYPE_p_GLFWwindow window)
        {
            if (glfwGetKey(window, GLFW_KEY_ESCAPE) == GLFW_PRESS)
                glfwSetWindowShouldClose(window,to_int(true));
        }

        static void framebuffer_size_callback(SWIGTYPE_p_GLFWwindow window, int width, int height)
        {
            // make sure the viewport matches the new window dimensions; note that width and 
            // height will be significantly larger than specified on retina displays.
            //glViewport(0, 0, width, height);
        }

        static int to_int(bool obj)
        {
            if (obj)
            {
                return 1;
            }
            else {
                return 0 ;
            }
        }
    }
}
