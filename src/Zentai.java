import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;

import javax.media.j3d.BoundingSphere;
import javax.media.j3d.Transform3D;
import javax.media.j3d.TransformGroup;

import com.sun.j3d.utils.behaviors.keyboard.KeyNavigatorBehavior;

public class Zentai extends TransformGroup implements KeyListener {

	TransformGroup transG1 =new TransformGroup();
	Transform3D trans=new Transform3D();
	Transform3D idou = new Transform3D();
	public Zentai(){
		addChild(transG1);
		transG1.setCapability(TransformGroup.ALLOW_TRANSFORM_READ);
		transG1.setCapability(TransformGroup.ALLOW_TRANSFORM_WRITE);
		BoundingSphere bounds = new BoundingSphere();
		KeyNavigatorBehavior knb = new KeyNavigatorBehavior(transG1);
		knb.setSchedulingBounds(bounds);
		transG1.addChild(new Prism());
		transG1.addChild(new Hidariashi());
		transG1.addChild(new Migiashi());
		transG1.addChild(new Migihand());
		transG1.addChild(new Hidarihand());
		transG1.addChild(new Head());
		//trans.setTranslation(new Vector3d(STEP,0.0,0.0));
		transG1.addChild(knb);
		//trans.set(new Vector3d(-STEP,0.0,0.0));
		//transG1.setTransform(trans);

	}
	@Override
	public void keyTyped(KeyEvent e) {

	}
	@Override
	public void keyPressed(KeyEvent e) {

	}
	@Override
	public void keyReleased(KeyEvent e) {


	}
}
