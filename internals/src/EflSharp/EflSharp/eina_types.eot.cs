#pragma warning disable CS1591
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
namespace Eina { 
public struct Unicode {
   private  uint payload;
   public static implicit operator Unicode( uint x)
   {
      return new Unicode{payload=x};
   }
   public static implicit operator  uint(Unicode x)
   {
      return x.payload;
   }
}
} 
namespace Eina { namespace Xattr { 
/// <summary>Eina file extended attributes flags</summary>
public enum Flags
{
/// <summary>This is the default behaviour, it will either create or replace the extended attribute</summary>
Insert = 0,
/// <summary>This will only succeed if the extended attribute previously existed</summary>
Replace = 1,
/// <summary>This will only succeed if the extended attribute wasn&apos;t previously set</summary>
Created = 2,
}
} } 
namespace Eina { 
/// <summary>A rectangle in pixel dimensions.</summary>
[StructLayout(LayoutKind.Sequential)]
public struct Rect
{
   /// <summary>X coordinate of the rectangle, from the top-left corner.</summary>
   public  int X;
   /// <summary>Y coordinate of the rectangle, from the top-left corner.</summary>
   public  int Y;
   /// <summary>Width of the rectangle in pixels.</summary>
   public  int W;
   /// <summary>Height of the rectangle in pixels.</summary>
   public  int H;
   ///<summary>Constructor for Rect.</summary>
   public Rect(
       int X=default( int),
       int Y=default( int),
       int W=default( int),
       int H=default( int)   )
   {
      this.X = X;
      this.Y = Y;
      this.W = W;
      this.H = H;
   }
public static implicit operator Rect(IntPtr ptr)
   {
      var tmp = (Rect_StructInternal)Marshal.PtrToStructure(ptr, typeof(Rect_StructInternal));
      return Rect_StructConversion.ToManaged(tmp);
   }
}
///<summary>Internal wrapper for struct Rect.</summary>
[StructLayout(LayoutKind.Sequential)]
public struct Rect_StructInternal
{
   
   public  int X;
   
   public  int Y;
   
   public  int W;
   
   public  int H;
   ///<summary>Implicit conversion to the internal/marshalling representation.</summary>
   public static implicit operator Rect(Rect_StructInternal struct_)
   {
      return Rect_StructConversion.ToManaged(struct_);
   }
   ///<summary>Implicit conversion to the managed representation.</summary>
   public static implicit operator Rect_StructInternal(Rect struct_)
   {
      return Rect_StructConversion.ToInternal(struct_);
   }
}
/// <summary>Conversion class for struct Rect</summary>
public static class Rect_StructConversion
{
   internal static Rect_StructInternal ToInternal(Rect _external_struct)
   {
      var _internal_struct = new Rect_StructInternal();

      _internal_struct.X = _external_struct.X;
      _internal_struct.Y = _external_struct.Y;
      _internal_struct.W = _external_struct.W;
      _internal_struct.H = _external_struct.H;

      return _internal_struct;
   }

   internal static Rect ToManaged(Rect_StructInternal _internal_struct)
   {
      var _external_struct = new Rect();

      _external_struct.X = _internal_struct.X;
      _external_struct.Y = _internal_struct.Y;
      _external_struct.W = _internal_struct.W;
      _external_struct.H = _internal_struct.H;

      return _external_struct;
   }

}
} 
namespace Eina { 
/// <summary>A 2D location in pixels.</summary>
[StructLayout(LayoutKind.Sequential)]
public struct Position2D
{
   /// <summary>X position in pixels, from the top-left corner.</summary>
   public  int X;
   /// <summary>Y position in pixels, from the top-left corner.</summary>
   public  int Y;
   ///<summary>Constructor for Position2D.</summary>
   public Position2D(
       int X=default( int),
       int Y=default( int)   )
   {
      this.X = X;
      this.Y = Y;
   }
public static implicit operator Position2D(IntPtr ptr)
   {
      var tmp = (Position2D_StructInternal)Marshal.PtrToStructure(ptr, typeof(Position2D_StructInternal));
      return Position2D_StructConversion.ToManaged(tmp);
   }
}
///<summary>Internal wrapper for struct Position2D.</summary>
[StructLayout(LayoutKind.Sequential)]
public struct Position2D_StructInternal
{
   
   public  int X;
   
   public  int Y;
   ///<summary>Implicit conversion to the internal/marshalling representation.</summary>
   public static implicit operator Position2D(Position2D_StructInternal struct_)
   {
      return Position2D_StructConversion.ToManaged(struct_);
   }
   ///<summary>Implicit conversion to the managed representation.</summary>
   public static implicit operator Position2D_StructInternal(Position2D struct_)
   {
      return Position2D_StructConversion.ToInternal(struct_);
   }
}
/// <summary>Conversion class for struct Position2D</summary>
public static class Position2D_StructConversion
{
   internal static Position2D_StructInternal ToInternal(Position2D _external_struct)
   {
      var _internal_struct = new Position2D_StructInternal();

      _internal_struct.X = _external_struct.X;
      _internal_struct.Y = _external_struct.Y;

      return _internal_struct;
   }

   internal static Position2D ToManaged(Position2D_StructInternal _internal_struct)
   {
      var _external_struct = new Position2D();

      _external_struct.X = _internal_struct.X;
      _external_struct.Y = _internal_struct.Y;

      return _external_struct;
   }

}
} 
namespace Eina { 
/// <summary>A 2D size in pixels.</summary>
[StructLayout(LayoutKind.Sequential)]
public struct Size2D
{
   /// <summary>X position in pixels, from the top-left corner.</summary>
   public  int W;
   /// <summary>Y position in pixels, from the top-left corner.</summary>
   public  int H;
   ///<summary>Constructor for Size2D.</summary>
   public Size2D(
       int W=default( int),
       int H=default( int)   )
   {
      this.W = W;
      this.H = H;
   }
public static implicit operator Size2D(IntPtr ptr)
   {
      var tmp = (Size2D_StructInternal)Marshal.PtrToStructure(ptr, typeof(Size2D_StructInternal));
      return Size2D_StructConversion.ToManaged(tmp);
   }
}
///<summary>Internal wrapper for struct Size2D.</summary>
[StructLayout(LayoutKind.Sequential)]
public struct Size2D_StructInternal
{
   
   public  int W;
   
   public  int H;
   ///<summary>Implicit conversion to the internal/marshalling representation.</summary>
   public static implicit operator Size2D(Size2D_StructInternal struct_)
   {
      return Size2D_StructConversion.ToManaged(struct_);
   }
   ///<summary>Implicit conversion to the managed representation.</summary>
   public static implicit operator Size2D_StructInternal(Size2D struct_)
   {
      return Size2D_StructConversion.ToInternal(struct_);
   }
}
/// <summary>Conversion class for struct Size2D</summary>
public static class Size2D_StructConversion
{
   internal static Size2D_StructInternal ToInternal(Size2D _external_struct)
   {
      var _internal_struct = new Size2D_StructInternal();

      _internal_struct.W = _external_struct.W;
      _internal_struct.H = _external_struct.H;

      return _internal_struct;
   }

   internal static Size2D ToManaged(Size2D_StructInternal _internal_struct)
   {
      var _external_struct = new Size2D();

      _external_struct.W = _internal_struct.W;
      _external_struct.H = _internal_struct.H;

      return _external_struct;
   }

}
} 
namespace Eina { 
/// <summary>Eina file data structure</summary>
[StructLayout(LayoutKind.Sequential)]
public struct File
{
///<summary>Placeholder field</summary>
public IntPtr field;
public static implicit operator File(IntPtr ptr)
   {
      var tmp = (File_StructInternal)Marshal.PtrToStructure(ptr, typeof(File_StructInternal));
      return File_StructConversion.ToManaged(tmp);
   }
}
///<summary>Internal wrapper for struct File.</summary>
[StructLayout(LayoutKind.Sequential)]
public struct File_StructInternal
{
internal IntPtr field;
   ///<summary>Implicit conversion to the internal/marshalling representation.</summary>
   public static implicit operator File(File_StructInternal struct_)
   {
      return File_StructConversion.ToManaged(struct_);
   }
   ///<summary>Implicit conversion to the managed representation.</summary>
   public static implicit operator File_StructInternal(File struct_)
   {
      return File_StructConversion.ToInternal(struct_);
   }
}
/// <summary>Conversion class for struct File</summary>
public static class File_StructConversion
{
   internal static File_StructInternal ToInternal(File _external_struct)
   {
      var _internal_struct = new File_StructInternal();


      return _internal_struct;
   }

   internal static File ToManaged(File_StructInternal _internal_struct)
   {
      var _external_struct = new File();


      return _external_struct;
   }

}
} 
namespace Eina { 
/// <summary>A simple 2D vector type using floating point values.</summary>
[StructLayout(LayoutKind.Sequential)]
public struct Vector2
{
   /// <summary>X coordinate.</summary>
   public double X;
   /// <summary>Y coordinate.</summary>
   public double Y;
   ///<summary>Constructor for Vector2.</summary>
   public Vector2(
      double X=default(double),
      double Y=default(double)   )
   {
      this.X = X;
      this.Y = Y;
   }
public static implicit operator Vector2(IntPtr ptr)
   {
      var tmp = (Vector2_StructInternal)Marshal.PtrToStructure(ptr, typeof(Vector2_StructInternal));
      return Vector2_StructConversion.ToManaged(tmp);
   }
}
///<summary>Internal wrapper for struct Vector2.</summary>
[StructLayout(LayoutKind.Sequential)]
public struct Vector2_StructInternal
{
   
   public double X;
   
   public double Y;
   ///<summary>Implicit conversion to the internal/marshalling representation.</summary>
   public static implicit operator Vector2(Vector2_StructInternal struct_)
   {
      return Vector2_StructConversion.ToManaged(struct_);
   }
   ///<summary>Implicit conversion to the managed representation.</summary>
   public static implicit operator Vector2_StructInternal(Vector2 struct_)
   {
      return Vector2_StructConversion.ToInternal(struct_);
   }
}
/// <summary>Conversion class for struct Vector2</summary>
public static class Vector2_StructConversion
{
   internal static Vector2_StructInternal ToInternal(Vector2 _external_struct)
   {
      var _internal_struct = new Vector2_StructInternal();

      _internal_struct.X = _external_struct.X;
      _internal_struct.Y = _external_struct.Y;

      return _internal_struct;
   }

   internal static Vector2 ToManaged(Vector2_StructInternal _internal_struct)
   {
      var _external_struct = new Vector2();

      _external_struct.X = _internal_struct.X;
      _external_struct.Y = _internal_struct.Y;

      return _external_struct;
   }

}
} 
namespace Eina { 
/// <summary>Eina 3x3 Matrix</summary>
[StructLayout(LayoutKind.Sequential)]
public struct Matrix3
{
   /// <summary>XX matrix value</summary>
   public double Xx;
   /// <summary>XY matrix value</summary>
   public double Xy;
   /// <summary>XZ matrix value</summary>
   public double Xz;
   /// <summary>YX matrix value</summary>
   public double Yx;
   /// <summary>YY matrix value</summary>
   public double Yy;
   /// <summary>YZ matrix value</summary>
   public double Yz;
   /// <summary>ZX matrix value</summary>
   public double Zx;
   /// <summary>ZY matrix value</summary>
   public double Zy;
   /// <summary>ZZ matrix value</summary>
   public double Zz;
   ///<summary>Constructor for Matrix3.</summary>
   public Matrix3(
      double Xx=default(double),
      double Xy=default(double),
      double Xz=default(double),
      double Yx=default(double),
      double Yy=default(double),
      double Yz=default(double),
      double Zx=default(double),
      double Zy=default(double),
      double Zz=default(double)   )
   {
      this.Xx = Xx;
      this.Xy = Xy;
      this.Xz = Xz;
      this.Yx = Yx;
      this.Yy = Yy;
      this.Yz = Yz;
      this.Zx = Zx;
      this.Zy = Zy;
      this.Zz = Zz;
   }
public static implicit operator Matrix3(IntPtr ptr)
   {
      var tmp = (Matrix3_StructInternal)Marshal.PtrToStructure(ptr, typeof(Matrix3_StructInternal));
      return Matrix3_StructConversion.ToManaged(tmp);
   }
}
///<summary>Internal wrapper for struct Matrix3.</summary>
[StructLayout(LayoutKind.Sequential)]
public struct Matrix3_StructInternal
{
   
   public double Xx;
   
   public double Xy;
   
   public double Xz;
   
   public double Yx;
   
   public double Yy;
   
   public double Yz;
   
   public double Zx;
   
   public double Zy;
   
   public double Zz;
   ///<summary>Implicit conversion to the internal/marshalling representation.</summary>
   public static implicit operator Matrix3(Matrix3_StructInternal struct_)
   {
      return Matrix3_StructConversion.ToManaged(struct_);
   }
   ///<summary>Implicit conversion to the managed representation.</summary>
   public static implicit operator Matrix3_StructInternal(Matrix3 struct_)
   {
      return Matrix3_StructConversion.ToInternal(struct_);
   }
}
/// <summary>Conversion class for struct Matrix3</summary>
public static class Matrix3_StructConversion
{
   internal static Matrix3_StructInternal ToInternal(Matrix3 _external_struct)
   {
      var _internal_struct = new Matrix3_StructInternal();

      _internal_struct.Xx = _external_struct.Xx;
      _internal_struct.Xy = _external_struct.Xy;
      _internal_struct.Xz = _external_struct.Xz;
      _internal_struct.Yx = _external_struct.Yx;
      _internal_struct.Yy = _external_struct.Yy;
      _internal_struct.Yz = _external_struct.Yz;
      _internal_struct.Zx = _external_struct.Zx;
      _internal_struct.Zy = _external_struct.Zy;
      _internal_struct.Zz = _external_struct.Zz;

      return _internal_struct;
   }

   internal static Matrix3 ToManaged(Matrix3_StructInternal _internal_struct)
   {
      var _external_struct = new Matrix3();

      _external_struct.Xx = _internal_struct.Xx;
      _external_struct.Xy = _internal_struct.Xy;
      _external_struct.Xz = _internal_struct.Xz;
      _external_struct.Yx = _internal_struct.Yx;
      _external_struct.Yy = _internal_struct.Yy;
      _external_struct.Yz = _internal_struct.Yz;
      _external_struct.Zx = _internal_struct.Zx;
      _external_struct.Zy = _internal_struct.Zy;
      _external_struct.Zz = _internal_struct.Zz;

      return _external_struct;
   }

}
} 
namespace Eina { 
/// <summary>Eina file direct information data structure</summary>
[StructLayout(LayoutKind.Sequential)]
public struct FileDirectInfo
{
///<summary>Placeholder field</summary>
public IntPtr field;
public static implicit operator FileDirectInfo(IntPtr ptr)
   {
      var tmp = (FileDirectInfo_StructInternal)Marshal.PtrToStructure(ptr, typeof(FileDirectInfo_StructInternal));
      return FileDirectInfo_StructConversion.ToManaged(tmp);
   }
}
///<summary>Internal wrapper for struct FileDirectInfo.</summary>
[StructLayout(LayoutKind.Sequential)]
public struct FileDirectInfo_StructInternal
{
internal IntPtr field;
   ///<summary>Implicit conversion to the internal/marshalling representation.</summary>
   public static implicit operator FileDirectInfo(FileDirectInfo_StructInternal struct_)
   {
      return FileDirectInfo_StructConversion.ToManaged(struct_);
   }
   ///<summary>Implicit conversion to the managed representation.</summary>
   public static implicit operator FileDirectInfo_StructInternal(FileDirectInfo struct_)
   {
      return FileDirectInfo_StructConversion.ToInternal(struct_);
   }
}
/// <summary>Conversion class for struct FileDirectInfo</summary>
public static class FileDirectInfo_StructConversion
{
   internal static FileDirectInfo_StructInternal ToInternal(FileDirectInfo _external_struct)
   {
      var _internal_struct = new FileDirectInfo_StructInternal();


      return _internal_struct;
   }

   internal static FileDirectInfo ToManaged(FileDirectInfo_StructInternal _internal_struct)
   {
      var _external_struct = new FileDirectInfo();


      return _external_struct;
   }

}
} 
namespace Eina { 
/// <summary>The structure to store some file statistics.</summary>
[StructLayout(LayoutKind.Sequential)]
public struct Stat
{
   /// <summary>The device where this file is located</summary>
   public  uint Dev;
   /// <summary>The inode</summary>
   public  uint Ino;
   /// <summary>The mode</summary>
   public  uint Mode;
   /// <summary>The link number</summary>
   public  uint Nlink;
   /// <summary>The owner user id</summary>
   public  uint Uid;
   /// <summary>The owner group id</summary>
   public  uint Gid;
   /// <summary>The remote device</summary>
   public  uint Rdev;
   /// <summary>The file size in bytes</summary>
   public  uint Size;
   /// <summary>The block size in bytes</summary>
   public  uint Blksize;
   /// <summary>The number of blocks allocated</summary>
   public  uint Blocks;
   /// <summary>The tilestamp when the file was last accessed</summary>
   public  uint Atime;
   /// <summary>The nano version of the timestmap when the file was last accessed</summary>
   public  uint Atimensec;
   /// <summary>The tilestamp when the file was modified</summary>
   public  uint Mtime;
   /// <summary>The nano version of the timestmap when the file was modified</summary>
   public  uint Mtimensec;
   /// <summary>The tilestamp when the file was created</summary>
   public  uint Ctime;
   /// <summary>The nano version of the timestmap when the file was created</summary>
   public  uint Ctimensec;
   ///<summary>Constructor for Stat.</summary>
   public Stat(
       uint Dev=default( uint),
       uint Ino=default( uint),
       uint Mode=default( uint),
       uint Nlink=default( uint),
       uint Uid=default( uint),
       uint Gid=default( uint),
       uint Rdev=default( uint),
       uint Size=default( uint),
       uint Blksize=default( uint),
       uint Blocks=default( uint),
       uint Atime=default( uint),
       uint Atimensec=default( uint),
       uint Mtime=default( uint),
       uint Mtimensec=default( uint),
       uint Ctime=default( uint),
       uint Ctimensec=default( uint)   )
   {
      this.Dev = Dev;
      this.Ino = Ino;
      this.Mode = Mode;
      this.Nlink = Nlink;
      this.Uid = Uid;
      this.Gid = Gid;
      this.Rdev = Rdev;
      this.Size = Size;
      this.Blksize = Blksize;
      this.Blocks = Blocks;
      this.Atime = Atime;
      this.Atimensec = Atimensec;
      this.Mtime = Mtime;
      this.Mtimensec = Mtimensec;
      this.Ctime = Ctime;
      this.Ctimensec = Ctimensec;
   }
public static implicit operator Stat(IntPtr ptr)
   {
      var tmp = (Stat_StructInternal)Marshal.PtrToStructure(ptr, typeof(Stat_StructInternal));
      return Stat_StructConversion.ToManaged(tmp);
   }
}
///<summary>Internal wrapper for struct Stat.</summary>
[StructLayout(LayoutKind.Sequential)]
public struct Stat_StructInternal
{
   
   public  uint Dev;
   
   public  uint Ino;
   
   public  uint Mode;
   
   public  uint Nlink;
   
   public  uint Uid;
   
   public  uint Gid;
   
   public  uint Rdev;
   
   public  uint Size;
   
   public  uint Blksize;
   
   public  uint Blocks;
   
   public  uint Atime;
   
   public  uint Atimensec;
   
   public  uint Mtime;
   
   public  uint Mtimensec;
   
   public  uint Ctime;
   
   public  uint Ctimensec;
   ///<summary>Implicit conversion to the internal/marshalling representation.</summary>
   public static implicit operator Stat(Stat_StructInternal struct_)
   {
      return Stat_StructConversion.ToManaged(struct_);
   }
   ///<summary>Implicit conversion to the managed representation.</summary>
   public static implicit operator Stat_StructInternal(Stat struct_)
   {
      return Stat_StructConversion.ToInternal(struct_);
   }
}
/// <summary>Conversion class for struct Stat</summary>
public static class Stat_StructConversion
{
   internal static Stat_StructInternal ToInternal(Stat _external_struct)
   {
      var _internal_struct = new Stat_StructInternal();

      _internal_struct.Dev = _external_struct.Dev;
      _internal_struct.Ino = _external_struct.Ino;
      _internal_struct.Mode = _external_struct.Mode;
      _internal_struct.Nlink = _external_struct.Nlink;
      _internal_struct.Uid = _external_struct.Uid;
      _internal_struct.Gid = _external_struct.Gid;
      _internal_struct.Rdev = _external_struct.Rdev;
      _internal_struct.Size = _external_struct.Size;
      _internal_struct.Blksize = _external_struct.Blksize;
      _internal_struct.Blocks = _external_struct.Blocks;
      _internal_struct.Atime = _external_struct.Atime;
      _internal_struct.Atimensec = _external_struct.Atimensec;
      _internal_struct.Mtime = _external_struct.Mtime;
      _internal_struct.Mtimensec = _external_struct.Mtimensec;
      _internal_struct.Ctime = _external_struct.Ctime;
      _internal_struct.Ctimensec = _external_struct.Ctimensec;

      return _internal_struct;
   }

   internal static Stat ToManaged(Stat_StructInternal _internal_struct)
   {
      var _external_struct = new Stat();

      _external_struct.Dev = _internal_struct.Dev;
      _external_struct.Ino = _internal_struct.Ino;
      _external_struct.Mode = _internal_struct.Mode;
      _external_struct.Nlink = _internal_struct.Nlink;
      _external_struct.Uid = _internal_struct.Uid;
      _external_struct.Gid = _internal_struct.Gid;
      _external_struct.Rdev = _internal_struct.Rdev;
      _external_struct.Size = _internal_struct.Size;
      _external_struct.Blksize = _internal_struct.Blksize;
      _external_struct.Blocks = _internal_struct.Blocks;
      _external_struct.Atime = _internal_struct.Atime;
      _external_struct.Atimensec = _internal_struct.Atimensec;
      _external_struct.Mtime = _internal_struct.Mtime;
      _external_struct.Mtimensec = _internal_struct.Mtimensec;
      _external_struct.Ctime = _internal_struct.Ctime;
      _external_struct.Ctimensec = _internal_struct.Ctimensec;

      return _external_struct;
   }

}
} 
