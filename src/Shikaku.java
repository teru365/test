
import javax.media.j3d.*;
import com.sun.j3d.utils.universe.*;
import com.sun.j3d.utils.behaviors.mouse.*;
import javax.vecmath.*;

class Shikaku extends Shape3D{
	public Shikaku(Point3f p0,Point3f p1,Point3f p2,Point3f p3,Appearance ap){
		Point3f[] vertex=new Point3f[4];
		vertex[0]=p0;
		vertex[1]=p1;
		vertex[2]=p2;
		vertex[3]=p3;
		QuadArray quadA=
			new QuadArray(vertex.length,GeometryArray.COORDINATES | GeometryArray.NORMALS);
		quadA.setCoordinates(0,vertex);
		Vector3f normal=new Vector3f();
		Vector3f vec1=new Vector3f();
		Vector3f vec2=new Vector3f();
		vec1.sub(p0,p1);
		vec2.sub(p0,p3);
		normal.cross(vec1,vec2);
		normal.normalize();
		for(int i=0;i<4;i++)quadA.setNormal(i,normal);
		setGeometry(quadA);
		setAppearance(ap);
	}
}
