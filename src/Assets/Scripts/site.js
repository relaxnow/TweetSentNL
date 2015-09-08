(function() {
    "use strict";
    var canvas = document.getElementById('smile');
    if (!canvas) {
        return;
    }

    var context = canvas.getContext('2d');
    var centerX = canvas.width / 2;
    var centerY = canvas.height / 2;
    var circleLineWidth = 5
    var radius = centerX - circleLineWidth;
    var eyeRadius = 40;
    var eyeXOffset = 100;
    var eyeYOffset = 20;

    context.beginPath();
    context.arc(centerX, centerY, radius, 0, 2 * Math.PI, false);
    context.fillStyle = 'yellow';
    context.fill();
    context.lineWidth = circleLineWidth;
    context.strokeStyle = 'black';
    context.stroke();

    context.save();
    context.scale(0.75, 1);
    context.beginPath();
    var eyeX = centerX - eyeXOffset;
    var eyeY = centerY - eyeXOffset;
    context.arc(eyeX * 1.25, eyeY * 1.25, eyeRadius, 0, Math.PI * 2, false);
    var eyeX = centerX + eyeXOffset * 1.25;
    context.arc(eyeX * 1.25, eyeY * 1.25, eyeRadius, 0, Math.PI * 2, false);
    context.fillStyle = 'black';
    context.fill();
    context.restore();

    context.beginPath();
    context.arc(centerX, centerY, 180, 0, Math.PI, false);
    context.stroke();
})();

(function($) {
  $('#Q').focus();
})(jQuery);