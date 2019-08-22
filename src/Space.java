import java.awt.BorderLayout;
import java.awt.Container;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;

import javax.media.j3d.Background;
import javax.media.j3d.BoundingSphere;
import javax.media.j3d.BranchGroup;
import javax.media.j3d.Canvas3D;
import javax.media.j3d.DirectionalLight;
import javax.media.j3d.GeometryArray;
import javax.media.j3d.Light;
import javax.media.j3d.LineArray;
import javax.media.j3d.Shape3D;
import javax.media.j3d.Transform3D;
import javax.media.j3d.TransformGroup;
import javax.swing.JFrame;
import javax.vecmath.Color3f;
import javax.vecmath.Point3d;
import javax.vecmath.Point3f;
import javax.vecmath.Vector3f;

import com.sun.j3d.utils.behaviors.mouse.MouseRotate;
import com.sun.j3d.utils.universe.SimpleUniverse;


public class Space extends JFrame implements KeyListener{

	private SimpleUniverse simpleU;
	private BoundingSphere bounds =
		new BoundingSphere(new Point3d(),10.0);
	TransformGroup transform=null;
	Transform3D translation=new Transform3D();
	Taiwa taiwa=null;
	public Space(Taiwa taiwa){
		this.taiwa=taiwa;
		Container cp =getContentPane();
		cp.setLayout(new BorderLayout());
		Canvas3D canvas =
			new Canvas3D(SimpleUniverse.getPreferredConfiguration());
		cp.add(canvas,BorderLayout.CENTER);
		canvas.addKeyListener(new Zentai());
		simpleU = new SimpleUniverse(canvas);
		simpleU.getViewingPlatform().setNominalViewingTransform();

		transform=simpleU.getViewingPlatform().getViewPlatformTransform();


		state(0,0,0.,0.,5f-2.41f);

		simpleU.addBranchGraph(createSceneGraph());

		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setSize(512,512);
		setVisible(true);
	}
		public void state(int x,int y,double xR,double yR,float kyori){
	//これは見え方をセットするメソッド
	//simpleUniverseから取り出したViewingPlatformのTransformを操作する
		float fx=x/100f;
		float fy=y/100f;
		translation.setTranslation(new Vector3f(fx,fy,kyori+2.41f));
		Transform3D rotX=new Transform3D();
		rotX.rotX(xR);
		Transform3D rotY=new Transform3D();
		rotY.rotY(-yR);
		Transform3D trans3D=new Transform3D();
		trans3D.mul(translation,rotX);
		trans3D.mul(trans3D,rotY);
		transform.setTransform(trans3D);//視点を制御する
	}
	private BranchGroup createSceneGraph(){

		BranchGroup branchG0 = new BranchGroup();

		Background background =
			new Background(new Color3f(0.3f,0.3f,0.3f));
		background.setApplicationBounds(bounds);
		branchG0.addChild(background);
		branchG0.addChild(createDirectionalLight());

		TransformGroup transG0= new TransformGroup();
		branchG0.addChild(transG0);
		//transG0.addChild(new Prism());//図体

		TransformGroup transG1= new TransformGroup();
		transG0.addChild(transG1);
		transG1.addChild(new heimen());

		//全体を動かすためのクラス
		TransformGroup transG7= new TransformGroup();
		transG0.addChild(transG7);
		transG7.addChild(new Zentai());

		//TransformGroup transG2= new TransformGroup();
		//transG0.addChild(transG2);
		//transG2.addChild(new Hidariashi());//左足

		//TransformGroup transG3= new TransformGroup();
		//transG0.addChild(transG3);
		//transG3.addChild(new Migiashi());//右足

//		TransformGroup transG4= new TransformGroup();
//		transG0.addChild(transG4);
//		transG4.addChild(new Migihand());//右腕
//
//		TransformGroup transG5= new TransformGroup();
//		transG0.addChild(transG5);
//		transG5.addChild(new Hidarihand());//左腕
//
//		TransformGroup transG6= new TransformGroup();
//		transG0.addChild(transG6);
//		transG6.addChild(new Head());//頭


		//参考のため法線を描く
	/*	Vector3f normal=new Vector3f(0f,0f,1f);
		normal.normalize();
		transG0.addChild(drawNormal(new Point3f(0f,0f,0f),normal));*/

		//マウスによる物体移動
		transG0.setCapability(
			TransformGroup.ALLOW_TRANSFORM_READ);
		transG0.setCapability(
			TransformGroup.ALLOW_TRANSFORM_WRITE);
		MouseRotate mouseRot = new MouseRotate(transG0);
		mouseRot.setSchedulingBounds(bounds);
		branchG0.addChild(mouseRot);

		branchG0.compile();

		return branchG0;
	}

	//平行光源を作成
	private Light createDirectionalLight(){
		DirectionalLight lightD =
			new DirectionalLight();
		lightD.setInfluencingBounds(bounds);
		return lightD;
	}

	//法線を作成する
	private Shape3D drawNormal(Point3f point1, Vector3f vec){
		Point3f point2 = new Point3f(point1);
		Point3f[]vertex =new Point3f[2];
		Color3f[] color =new Color3f[2];

		vec.scale(0.5f);
		point2.add(vec);

		vertex[0] = point1;
		vertex[1] = point2;
		color[0] = new Color3f(1f,1f,0f);
		color[1] = new Color3f(1f,1f,0f);

		LineArray lineA =
			new LineArray(vertex.length,
				GeometryArray.COORDINATES | GeometryArray.COLOR_3);
		lineA.setCoordinates(0,vertex);
		lineA.setColors(0, color);
		Shape3D line3D = new Shape3D(lineA);

		return line3D;
	}
	@Override
	public void keyTyped(KeyEvent e) {

	}
	@Override
	public void keyPressed(KeyEvent e) {

	}
	@Override
	public void keyReleased(KeyEvent e) {
		// TODO 自動生成されたメソッド・スタブ

	}

}
