//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class GLFWimage : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GLFWimage(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GLFWimage obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~GLFWimage() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          glfw3PINVOKE.delete_GLFWimage(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int width {
    set {
      glfw3PINVOKE.GLFWimage_width_set(swigCPtr, value);
    } 
    get {
      int ret = glfw3PINVOKE.GLFWimage_width_get(swigCPtr);
      return ret;
    } 
  }

  public int height {
    set {
      glfw3PINVOKE.GLFWimage_height_set(swigCPtr, value);
    } 
    get {
      int ret = glfw3PINVOKE.GLFWimage_height_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_char pixels {
    set {
      glfw3PINVOKE.GLFWimage_pixels_set(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = glfw3PINVOKE.GLFWimage_pixels_get(swigCPtr);
      SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
      return ret;
    } 
  }

  public GLFWimage() : this(glfw3PINVOKE.new_GLFWimage(), true) {
  }

}
