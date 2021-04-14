# wpf-button
### About us

> &nbsp; :adult: __James Lee__ &nbsp;&nbsp; [Github](https://github.com/devncore-james) &nbsp;&nbsp; james.lee@devncore.org  
> &nbsp; :woman: __Elena Kim__ &nbsp;&nbsp; [Github](https://github.com/devncore-elena) &nbsp;&nbsp; elena.kim@devncore.org

We are very ordinary developers, so we need to communicate with you.   
You can always share information with us and we are looking forward to it.  

##### _Open Source &nbsp; https://github.com/devncore/devncore   &nbsp;&nbsp;   Official Website &nbsp; https://devncore.org_ 

### License Policy
[![MIT license](https://img.shields.io/badge/License-MIT-blue.svg)](https://lbesson.mit-license.org/)
[![GPLv3 license](https://img.shields.io/badge/License-GPLv3-blue.svg)](http://perso.crans.org/besson/LICENSE.html)

***

### WPF에서 가장 많이 사용되는 컨트롤 중 하나인 Button에 관한 연구를 진행합니다.

📖 **연구 항목**
- [x] Button Class
- [x] Template
- [x] Geometry
- [x] Trigger
- [x] DataContext
- [x] DependencyProperty
- [x] [Example Buttons](#example-buttons)

> 목표: (속도는 더디지만) 각 항목에 대한 설명 및 소스코드를 상세하게 정리함으로써 **WPF Button 관련 정보들을 검증하고 지속적으로 관리해 나가는 것**을 목표로 하고 있습니다. :smile:
<br />

## Button Class (버튼 클래스) 

| 이름 | UI 타입 | 네임스페이스 | 어셈블리 |
| :-----------: | :----: | :-------------------: | :---------------: |
| Button | ContentControl | System.Windows.Controls | PresentationFramework.dll |

WPF **버튼**은 Content 속성을 포함하는 ContentControl 기반의 클래스입니다. ContentControl을 기반으로 하는 클래스는 Button 이외에도 Window, UserControl, CheckBox, ToggleButton, Expander 등이 있습니다.

Button 클래스의 가장 큰 특징은 ContentTemplate을 편집할 수 있다는 점과, Click 이벤트를 포함한 Button 동작 관련 Event를 사용할 수 있다는 점입니다. 또한 다른 UI 클래스들과 달리 Command라는 ICommand 타입 속성(DependencyProperty)을 통해 Click 이벤트를 Binding으로 연결할 수도 있습니다. 이는 Button 클릭 시 내부적으로 Command를 `?.Invoke()` 하도록 설계되어 있기 때문입니다.

**기본 스타일 형태** 

```xaml
<Style TargetType="{x:Type Button}">
    <Setter>
        <Setter.Value>
            <ControlTemplate TargetType="{x:Type Button}">
                <ControlTemplate.Resources>
                   <Style TargetType="{x:Type Border}" x:Key="IN.BORDER">
                       <Setter Property="Background" Value="#EEEEEE"/>
                   </Style>
                </ControlTemplate.Resources>
                <Border Style="{StaticResource IN.BORDER}">                    
                    <ContentPresenter ContentSource="Content"/>
                </Border>
            </ControlTemplate>
       </Setter.Value>
   </Setter>
</Style>
```
#### _`ControlTemplate.Resources`를 사용하는이유?_
&nbsp; 👉 일반적으로 **ControlTemplate** 영역 자체가 Base 기반이기 때문에 한 단계 더 정리해야 할 필요성을 느끼지 못할 수도 있습니다. 하지만 **분명한** 것은 Template 영역에서 Style 규칙을 더욱 강력하고 철저하게 가져가지 않는다면 **Xaml 확장 및 리소스 관리의 한계**에 금세 봉착하게 될 것입니다. Style 규칙에 대한 보다 자세한 설명은 **[여기](https://github.com/devncore/wpf-code-rules)** 에서 확인할 수 있습니다.

**Button과 거의(99%) 동일한** ~~DNA~~
ContentControl을 기반으로 한 모든 컨트롤이 대상입니다.
- ToggleButton
- CheckBox
- RadioButton
- Window
- UserControl

***

## Example Buttons
- [GitHub Button](#github-button)
- 닷넷데브 버튼
- 카카오톡 버튼
- 리그오브레전드 버튼
- 

### GitHub Button

#### Solution
&nbsp; 📁 DevNcoreButtonExample  
&nbsp;&nbsp;└ [:open_file_folder:](https://github.com/devncore/wpf-button/tree/main/DevNcoreButtonExample/GitHubControls) GitHubControls

#### 기본 상태 (Default)
![image](https://user-images.githubusercontent.com/52397976/114562527-8766cf00-9ca9-11eb-8a5a-50976c6025fa.png)

#### 색상 표 (HEX)
| Color | Hex | Control  | Property | Trigger |
| :---: | --- | -------- | -------- | ------- |
| ![image](https://user-images.githubusercontent.com/52397976/114568404-0dd1df80-9caf-11eb-8a92-f871843069fa.png) | #2B9148 | Border    | BorderBrush |             |
| ![image](https://user-images.githubusercontent.com/52397976/114568356-03afe100-9caf-11eb-9215-417e293c3e38.png) | #2EA44F | Border    | Background  |             |
| ![image](https://user-images.githubusercontent.com/52397976/114568280-f4c92e80-9cae-11eb-85b4-eefd7314c143.png) | #FFFFFF | TextBlock | Foreground  |             |
| ![image](https://user-images.githubusercontent.com/52397976/114568280-f4c92e80-9cae-11eb-85b4-eefd7314c143.png) | #FFFFFF | Path      | Fill        |             |
| ![image](https://user-images.githubusercontent.com/52397976/114568711-55f10200-9caf-11eb-813b-126a4b8f7dbe.png) | #2C974B | Border    | Background  | IsMouseOver |
| ![image](https://user-images.githubusercontent.com/52397976/114568356-03afe100-9caf-11eb-9215-417e293c3e38.png) | #2EA44F | Border    | Background  | IsPressed   |

#### 아이콘 (Geometry)  
```xaml
<Geometry x:key="ICON">M8,8V6H10V8H8M7,2H17A2,2 0 0,1 19,4V19A2,2 0 0,1 17,21V22H15V21H9V22H7V21A2,2 0 0,1 5,19V4A2,2 0 0,1 7,2M7,4V9H17V4H7M8,12V15H10V12H8Z</Geometry>
```
 
#### 스타일 (ControlTemplate) 
```xaml
<!-- Geometry Path Icon (.SVG) -->
<Geometry x:Key="ICON">M8,8V6H10V8H...</Geometry>

<!-- GitHub Button Style -->
<Style TargetType="{x:Type local:GitHubButton}">
	<Setter Property="UseLayoutRounding" Value="True"/>
	<Setter Property="SnapsToDevicePixels" Value="True"/>
	<Setter Property="Foreground" Value="#FFFFFF"/>
	<Setter Property="FontWeight" Value="Bold"/>
	<Setter Property="Margin" Value="5"/>
	<Setter Property="Template">
        <Setter.Value>
            <ControlTemplate TargetType="{x:Type local:GitHubButton}">
		<ControlTemplate.Resources>
			<Style TargetType="{x:Type Border}" x:Key="IN.BORDER">
				<Setter Property="BorderBrush" Value="#2B9148"/>
				<Setter Property="BorderThickness" Value="1 1 1 1"/>
				<Setter Property="Background" Value="#2B9148"/>
				<Setter Property="CornerRadius" Value="5"/>
			</Style>
			<Style TargetType="{x:Type StackPanel}" x:Key="IN.PANEL">
				<Setter Property="VerticalAlignment" Value="Center"/>
				<Setter Property="Orientation" Value="Horizontal"/>
			</Style>
			<Style TargetType="{x:Type Viewbox}" x:Key="IN.VBOX">
				<Setter Property="VerticalAlignment" Value="Center"/>
				<Setter Property="Margin" Value="12 0 4 0"/>
				<Setter Property="Width" Value="16"/>
				<Setter Property="Height" Value="16"/>
			</Style>
			<Style TargetType="{x:Type Path}" x:Key="IN.PATH">
				<Setter Property="Data" Value="{StaticResource ICON}"/>
				<Setter Property="Width" Value="24"/>
				<Setter Property="Height" Value="24"/>
				<Setter Property="Fill" Value="#FFFFFF"/>
			</Style>
			<Style TargetType="{x:Type ContentPresenter}" x:Key="IN">
				<Setter Property="VerticalAlignment" Value="Center"/>
				<Setter Property="Margin" Value="0 6 12 6"/>
			</Style>
		</ControlTemplate.Resources>
                <Border Style="{StaticResource IN.BORDER}">
			<StackPanel Style="{StaticResource IN.PANEL}">
				<Viewbox Style="{StaticResource IN.VBOX}">
					<Path Style="{StaticResource IN.PATH}"/>
				</Viewbox>
				<ContentPresenter Style="{StaticResource IN}"/>
			</StackPanel>
		</Border>
            </ControlTemplate>
        </Setter.Value>
    </Setter>
</Style>
```

#### ControlTemplate 영역 하위 컨트롤 스타일
| x:Key | TargetType | Remark |
| :---: | :-------------: | :--------|
| **IN.BORDER** | Border | CornerRadius="5 5 5 5"|
| **IN.PANEL** | StackPanel | Orientation="Horizontal" |
| **IN.VBOX** | ViewBox | W16 x H16 |
| **IN.PATH** | Path | W24 x H24 (실제 .svg size) |
| **IN** | ContentPresenter | ContentSource="Content" |
 <br/>

**WPF 실행 결과**

![image](https://user-images.githubusercontent.com/52397976/114562040-18897600-9ca9-11eb-80a6-737778d4cd51.png)
