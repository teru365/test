import java.awt.Container;

import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JSlider;
import javax.swing.SwingConstants;
import javax.swing.event.ChangeEvent;
import javax.swing.event.ChangeListener;

class Taiwa extends JFrame implements ChangeListener{
	JSlider xs=new JSlider();
	JSlider ys=new JSlider(SwingConstants.VERTICAL);
	JSlider shikakuYS=new JSlider();
	JSlider shikakuXS=new JSlider(SwingConstants.VERTICAL);
	JSlider kyoriS=new JSlider(SwingConstants.VERTICAL);
	Space space=null;
	public Taiwa(){
		setTitle("視点制御盤");
		space=new Space(this);
		Container cp=getContentPane();
		cp.setLayout(null);
		JLabel xsL=new JLabel("x方向移動");
		cp.add(xsL);
		xsL.setBounds(0,0,100,40);
		cp.add(xs);
		xs.addChangeListener(this);
		xs.setBounds(100,0,200,40);
		JLabel shikakuYSL=new JLabel("視覚ｙ回転");
		cp.add(shikakuYSL);
		shikakuYSL.setBounds(0,40,100,40);
		cp.add(shikakuYS);
		shikakuYS.setBounds(100,40,200,40);
		shikakuYS.addChangeListener(this);

		JLabel ysL=new JLabel("y方向移動");
		cp.add(ysL);
		ysL.setBounds(0,80,100,40);
		cp.add(ys);
		ys.setBounds(0,120,40,200);
		ys.addChangeListener(this);

		JLabel shikakuXSL=new JLabel("視覚x回転");
		cp.add(shikakuXSL);
		shikakuXSL.setBounds(100,80,100,40);
		cp.add(shikakuXS);
		shikakuXS.setBounds(100,120,40,200);
		shikakuXS.addChangeListener(this);

		JLabel kyoriSL=new JLabel("視点距離");
		cp.add(kyoriSL);
		kyoriSL.setBounds(200,80,100,40);
		cp.add(kyoriS);
		kyoriS.setBounds(200,120,40,200);
		kyoriS.addChangeListener(this);

		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setSize(360,360);
		setLocation(1005,0);
		setVisible(true);
	}
	public void stateChanged(ChangeEvent evt){
		int x=xs.getValue()-50;
		int y=ys.getValue()-50;
		double xR=(shikakuXS.getValue()-50)/100.*Math.PI;
		double yR=(shikakuYS.getValue()-50)/100.*Math.PI;
		float kyori=(kyoriS.getValue()-24.1f)/10f;
		space.state(x*10,y*10,xR,yR,kyori);

	}
	public static void main(String []args){
		new Taiwa();
	}
}

