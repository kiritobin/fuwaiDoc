var can = document.getElementById('can'),
	pan,
	index = 0,
	flag = true,
	wid = document.body.clientWidth,
	hei = document.body.clientHeight,
	x = 0,
	y = hei / 2;
start();

function start() {
	can.height = hei;
	can.width = wid;
	pan = can.getContext("2d"); //获取2D图像API接口
	pan.strokeStyle = "#000"; //设置画笔颜色
	pan.lineJoin = "round"; //设置画笔轨迹基于圆点拼接
	pan.lineWidth = 8; //设置画笔粗细
	pan.beginPath();
	pan.moveTo(x, y);
	index = setInterval(move, 1);
};

function move() {
	x++;
	if(x < 100) {

	} else {
		if(x >= wid - 100) {

		} else {
			var z = Math.random() * 280;
			if(y <= z) {
				flag = true
			}
			if((hei - y) <= z) {
				flag = false
			}
			if(flag) {
				y += 5
			} else {
				y -= 5
			}
		}
	}
	if(x == wid) {
		pan.closePath();
		clearInterval(index);
		index = 0;
		x = 0;
		y = hei / 2;
		flag = true;
		start();
	}
	pan.lineTo(x, y);
	pan.stroke();
}