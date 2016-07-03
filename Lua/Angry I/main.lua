-----------------------------------------------------------------------------------------
--
-- main.lua
--
-----------------------------------------------------------------------------------------

-- Your code here

local physics= require("physics")
physics.start()

local circle = display.newCircle(50,10,30)
physics.addBody(circle,"dynamic", {density=1.0, friction=0.3,
bounce=0.2, radius=40})


local floor= display.newRect(0,500,1024,4)
physics.addBody(floor,"static", {density=1.0, friction=0.3,
bounce=0.2})


for i=0, 10 do

local rect= display.newRect(200, 150+i*40,10,30)
physics.addBody(rect, "dynamic", {density=1.0, friction=0.3,
bounce=0.2, isSensor= false})


end


function circleTouched(event)

	if event.phase=="began" then
		display.getCurrentStage():setFocus(circle)
	elseif event.phase=="ended" then

	circle:applyLinearImpulse(event.xStart - event.x, event.yStart
	- event.y, circle.x, circle.y)

		display.getCurrentStage():setFocus(nil)

		end


end

circle:addEventListener("touch", circleTouched)
