import java.awt.*;
import javax.media.j3d.*;
import com.sun.j3d.utils.universe.*;
import com.sun.j3d.utils.behaviors.mouse.*;
import javax.vecmath.*;


public class heimen extends TransformGroup{
	public heimen(){
		Transform3D trans =new Transform3D();
		Appearance ap=new Appearance();
		PolygonAttributes pa =new PolygonAttributes();
		ap.setPolygonAttributes(pa);
		ColoringAttributes ca = new ColoringAttributes();
		ca.setColor(1f,0f,0f);
		ap.setColoringAttributes(ca);
		Material ma =new Material();
		ma.setDiffuseColor(new Color3f(1f,0f,0f));
		ma.setSpecularColor(new Color3f(1f,0.5f,0.5f));
		ma.setShininess(100f);
		ap.setMaterial(ma);
//底面
		Point3f[]vertex=new Point3f[10];
		vertex[0]=new Point3f(0f,0.5f,1f);
		vertex[1]=new Point3f(-2f,0f,1f);
		vertex[2]=new Point3f(2f,0f,1f);
		vertex[3]=new Point3f(0f,0.5f,-1f);
		vertex[4]=new Point3f(-2f,0.0f,-1f);
		vertex[5]=new Point3f(2f,0f,-1f);
		//底面2
		vertex[6]=new Point3f(-2f,0f,1f);
		vertex[7]=new Point3f(-2.0f,0.0f,-1.0f);
		vertex[8]=new Point3f(2f,0f,-1f);
		vertex[9]=new Point3f(2f,0f,1f);
		//底面
		addChild(new Shikaku(vertex[1],vertex[4],vertex[5],vertex[2],ap));
		//底面2
		addChild(new Shikaku(vertex[9],vertex[8],vertex[7],vertex[6],ap));
	
	}

}