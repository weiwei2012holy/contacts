## avalonia 初体验

### 前言

- 都是前端渲染层面的内容,可以类比 HTML CSS 这一套

### 常用组件

#### 布局和基础

| 类型            | 描述                                                       | 类比 HTML                | 用法说明                                                                                            |
|---------------|----------------------------------------------------------|------------------------|-------------------------------------------------------------------------------------------------|
| Window        | 顶级组件                                                     | body                   | `Title` `Icon` `WindowState`    `SizeToContent`                                                 |
| Border        | 边框,包裹一个子元素                                               | div>p                  | 背景：`Background`，边框颜色：`BorderBrush` 边框大小：`BorderThickness` 圆角[可多值]：`CornerRadius` 阴影:`BoxShadow` |
| Panel         | 所有提供布局支持的元素的基类                                           |                        |                                                                                                 |
| DockPanel     | 用于划分空间，比如常见的后台系统，左:菜单，右上：操作栏，右下：主页面，底部：footer            |                        | 定位[上下左右]：`DockPanel.Dock.Left`                                                                  | 
| StackPanel    | 横向/纵向堆叠元素，比如渲染按钮组，列表等                                    |                        | 排列方向：`Orientation`  元素间隔：`Spacing`                                                              |
| WrapPanel     | 可以自动换行                                                   |                        |                                                                                                 |
| RelativePanel |                                                          |                        |                                                                                                 |
| Canvas        | 许按绝对 x- 和 y- 坐标定位内容。元素可以绘制在唯一位置【堆叠】                      |                        |                                                                                                 |
| Grid          | 允许您定义灵活的行和列分组 ，唯一可以按屏幕空间的百分比划分布局面板（start模式：* 2*）         |                        |                                                                                                 | 
| GridSplitter  | 允许用户调整尺寸                                                 |                        |                                                                                                 | 
| UniformGrid   | 提供统一网格布局的面板类型  ，在需要以网格格式显示项目集合的情况下，每个项目占用相同的空间（中心点都是对其的） |                        |                                                                                                 |                                               
| ScrollBar     | 滚动条，可以获取0-100之间的float值                                   |                        |                                                                                                 |`Orientation` 
| ScrollViewer  | 带滚动条的容器                                                  | overflow：scroll        |                                                                                                 |`AllowAutoHide` 
| SplitView     | 抽屉效果：主容器，副容器                                             |                        |                                                                                                 |`AllowAutoHide` 
| TabControl    | 带tab的切换页面                                                | TabControl>TabItem>xxx |                                                                                                 |`AllowAutoHide` 
| Expander      | 带 header 的折叠面板                                           |                        | `Expander.Header`                                                                               |
| Flyout        | 可呼出内容,常用于附加到其他组件交互上                                      |                        | 显示位置:`Placement`                                                                                |
| Image         | 渲染图像                                                     | image                  | 图像地址:`Source`                                                                                   |
| PathIcon      | 渲染Icon图像                                                 | SVG                    | 图像地址:`Data`       颜色:`Foreground`                                                               |
| Viewbox       | 可缩放内部元素                                                  |                        |                                                                                                 |

##### 布局常见属性

| 属性                  | 用途        | 类比 HTML |
|---------------------|-----------|---------|
| HorizontalAlignment | 元素本身-水平对齐 | float   |
| VerticalAlignment   | 元素本身-垂直对齐 |         |
|                     |           |         |

#### 日期和时间

| 组件         | 用途   | 类比 HTML | 属性用法 |
|------------|------|---------|------|
| Calendar   | 日历   |         |      |
| DatePicker | 日期选择 |         |      |
| TimePicker | 时间选择 |         |

#### 表单控制输入

| 组件                | 用途          | 类比 HTML              | 属性用法                                                                                   |
|-------------------|-------------|----------------------|----------------------------------------------------------------------------------------|
| Button            | 按钮          | input:button         |                                                                                        |
| RadioButton       | 单选框         | input:radio          |                                                                                        |
| SplitButton       | 分裂按钮        |                      | 点击后可以打开二级菜单                                                                            |
| ToggleButton      | 切换按钮        | Switch               |                                                                                        |
| ToggleSplitButton | 切换分裂按钮      | Switch               |                                                                                        |
| ButtonSpinner     | 按钮微调器       |                      | 按钮微调器是一个包含向上和向下微调按钮的控件                                                                 |
| RepeatButton      | 重复按钮        |                      | 其特点是在按住按钮时定期生成点击事件，`Delay` `Interval`                                                  |
| CheckBox          | 多选框         | input:CheckBox       | 第三种状态：`IsThreeState` 默认选中：`IsChecked`                                                  |
| TextBox           | 文本输入框       | input:text  textarea |                                                                                        |
| TextBlock         | 文本标签        | H,P                  | 字体大小：`FontSize` 粗细： `FontWeight` 样式：`FontStyle` 装饰：`TextDecorations` 渲染换行: `xml:space` |
| MaskedTextBox     | 文本输入框[带格式]  |                      | 手机号，银行卡等有固定格式和长度的文本 模版：`Mask`                                                          |
| ComboBoxItem      | 下拉列表        | select               |                                                                                        |
| Slider            | 滑动输入        |                      |                                                                                        |
| NumericUpDown     | 数值输入[带上下箭头] |                      |                                                                                        |
| AutoCompleteBox   | 带输入提示的文本输入框 |                      |                                                                                        |

#### 菜单

| 组件          | 用途      | 属性用法        |
|-------------|---------|-------------|
| MenuFlyout  | 呼出菜单    |             |
| ContextMenu | 右键菜单    |             |
| Menu        | 应用菜单    | 一般放在软件顶部    |
| NativeMenu  | 系统级菜单   | 比如 MAC 顶部菜单 |
| Separator   | 分割线     |             |
| TabStrip    | Tab切换菜单 |             |

#### 数据渲染

| 组件           | 用途              | 类比 HTML                                         | 属性用法                                                                                                                                                                             |
|--------------|-----------------|-------------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| DataGrid     | 网格数据            | table                                           | 数据源：`ItemsSource` <br/>自动表头:`AutoGenerateColumns` <br/>绑定方式:`IsReadOnly` <br/>拖动修改表头排序:`CanUserReorderColumns` <br/>修改表头尺寸:`CanUserResizeColumns` <br/>表头排序:`CanUserSortColumns` |
| ListBox      | 列表,可以选择         |                                                 | 数据绑定:`Items` <br/>选中模式:`SelectionMode` [Single,Multiple,Toggle,AlwaysSelected]                                                                                                   |
| ComboBoxItem | 下拉列表,可以选择       |                                                 | 数据绑定:`Items` <br/>选中模式:`SelectionMode` [Single,Multiple,Toggle,AlwaysSelected]                                                                                                   |
| ItemsControl | 列表组件,可以提供更多格式渲染 | ItemsControl>DataTemplate>xx                    |                                                                                                                                                                                  |
| ItemsControl | 列表组件,带布局和数据模版   | ItemsRepeater>ItemsRepeater.Layout              | 可以配置 layout StackPanel 实现横向排列                                                                                                                                                    |
| ProgressBar  | 进度条             |                                                 |                                                                                                                                                                                  |
| TextBlock    | 文本标签            |                                                 |                                                                                                                                                                                  |
| TreeView     | 树状渲染            | TreeView>TreeView.ItemTemplate>TreeDataTemplate |                                                                                                                                                                                  |

### 样式