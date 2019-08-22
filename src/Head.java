import javax.media.j3d.Appearance;
import javax.media.j3d.ColoringAttributes;
import javax.media.j3d.Material;
import javax.media.j3d.PolygonAttributes;
import javax.media.j3d.Transform3D;
import javax.media.j3d.TransformGroup;
import javax.vecmath.Color3f;
import javax.vecmath.Vector3f;

import com.sun.j3d.utils.geometry.Box;

public class Head extends TransformGroup{

	public Head(){
		TransformGroup transG1 =new TransformGroup();
		addChild(transG1);

		transG1.setCapability(TransformGroup.ALLOW_TRANSFORM_READ);
		transG1.setCapability(TransformGroup.ALLOW_TRANSFORM_WRITE);

		Appearance ap=new Appearance();
		PolygonAttributes pa =new PolygonAttributes();
		ap.setPolygonAttributes(pa);
		ColoringAttributes ca = new ColoringAttributes();
		ca.setColor(0f,0f,1.0f);
		ap.setColoringAttributes(ca);
		Material ma =new Material();
		ma.setDiffuseColor(new Color3f(0f,1.0f,0f));
		ma.setSpecularColor(new Color3f(0f,0.5f,0.5f));
		ma.setShininess(100f);
		ap.setMaterial(ma);
		Box box = new Box(0.05f,0.1f,0.05f, ap);
		transG1.addChild(box);
		Transform3D trans=new Transform3D();
		trans.setTranslation(new Vector3f(0.0f,0.50f,0.0f));
		transG1.setTransform(trans);
		//addChild(new Box(0.2f,0.5f,0.2f, ap));
	}

}