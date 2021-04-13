# wpf-button
WPF에서 가장 많이 사용되는 컨트롤 중에 하나인 Button에 관한 연구를 진행합니다.

연구 항목

버튼(Button) 사례
Button Class
Template
Geometry
Trigger
DataContext
DependencyProperty
목표: (속도는 더디지만) 설명과 소스코드를 상세하게 정리하고 WPF Button 관련 정보들을 잘 검증고 지속적으로 관리해 나가는 것에 목적을 두고 있습니다. :smile:





### Button Class (버튼 클래스)
 

| 이름 | UI 타입 | 네임스페이스   | 어셈블리 |
| :----------- | :---- | :------------------- | :--------------- |
| Button | ContentControl | System.Windows.Controls | PresentationFramework.dll |

WPF **버튼**은 Content 속성을 포함하는 ContentControl 기반의 클래스입니다. ContentControl을 기반으로 하는 클래스는 Button 말고도 Window, UserControl, CheckBox, ToggleButton, Expander 등이 있습니다.

Button 클래스의 가장 큰 특징은  ContentTemplate을 편집할 수 있다는 점과 Click 이벤트를 포함한 Button 동작에 관련된 Event를 사용할 수 있다는 점입니다. 또한 다른 UI 클래스들과 달리 Command라는 ICommand 타입의 속성(DependencyProperty)를 통해 Click 이벤트를 Binding을 통해 연결할 수도 있습니다. 이는 Button 내부적으로 버튼 클릭 시 Command를 ?.Invoke() 하도록 설계되어 있기 때문입니다.

**기본 스타일 형태** 

```
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
일반적으로 **ControlTemplate**을 만들 때 속성 값을 직접 사용하게 됩니다. 왜냐하면 이 영역 자체가 Base 기반이기 때문에 한단계 더 정리해야 할 필요성을 느끼지 못할 수도 있기 때문입니다. 하지만 **분명한** 것은 Template 영역에서 Style 규칙을 더 강력하고 철저하게 가져가지 않는다면 금방 Xaml 확장, 관리의 한계에 봉착할 것입니다. 이 규칙에 대한 설명은 [여기](https://github.com/devncore/wpf-code-rules)에서 좀 더 자세히 학습할 수 있습니다.

**Button과 거의(99%) 동일한** ~~DNA~~
ContentControl을 기반으로 한 모든 컨트롤이 대상입니다.
- ToggleButton
- CheckBox
- RadioButton
- Window
- UserControl

TBD...
