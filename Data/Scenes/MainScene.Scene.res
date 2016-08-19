<root dataType="Struct" type="Duality.Resources.Scene" id="129723834">
  <assetInfo />
  <globalGravity dataType="Struct" type="Duality.Vector2">
    <X dataType="Float">0</X>
    <Y dataType="Float">33</Y>
  </globalGravity>
  <serializeObj dataType="Array" type="Duality.GameObject[]" id="427169525">
    <item dataType="Struct" type="Duality.GameObject" id="1404595237">
      <active dataType="Bool">true</active>
      <children dataType="Struct" type="System.Collections.Generic.List`1[[Duality.GameObject]]" id="4132922455">
        <_items dataType="Array" type="Duality.GameObject[]" id="2126658062" length="4">
          <item dataType="Struct" type="Duality.GameObject" id="1884001978">
            <active dataType="Bool">true</active>
            <children />
            <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="2339996126">
              <_items dataType="Array" type="Duality.Component[]" id="1533480208" length="4">
                <item dataType="Struct" type="Duality.Components.Transform" id="4244316910">
                  <active dataType="Bool">true</active>
                  <angle dataType="Float">0</angle>
                  <angleAbs dataType="Float">0</angleAbs>
                  <angleVel dataType="Float">0</angleVel>
                  <angleVelAbs dataType="Float">0</angleVelAbs>
                  <deriveAngle dataType="Bool">true</deriveAngle>
                  <gameobj dataType="ObjectRef">1884001978</gameobj>
                  <ignoreParent dataType="Bool">false</ignoreParent>
                  <parentTransform dataType="Struct" type="Duality.Components.Transform" id="3764910169">
                    <active dataType="Bool">true</active>
                    <angle dataType="Float">0</angle>
                    <angleAbs dataType="Float">0</angleAbs>
                    <angleVel dataType="Float">0</angleVel>
                    <angleVelAbs dataType="Float">0</angleVelAbs>
                    <deriveAngle dataType="Bool">true</deriveAngle>
                    <gameobj dataType="ObjectRef">1404595237</gameobj>
                    <ignoreParent dataType="Bool">false</ignoreParent>
                    <parentTransform />
                    <pos dataType="Struct" type="Duality.Vector3" />
                    <posAbs dataType="Struct" type="Duality.Vector3" />
                    <scale dataType="Float">1</scale>
                    <scaleAbs dataType="Float">1</scaleAbs>
                    <vel dataType="Struct" type="Duality.Vector3" />
                    <velAbs dataType="Struct" type="Duality.Vector3" />
                  </parentTransform>
                  <pos dataType="Struct" type="Duality.Vector3">
                    <X dataType="Float">0</X>
                    <Y dataType="Float">0</Y>
                    <Z dataType="Float">500</Z>
                  </pos>
                  <posAbs dataType="Struct" type="Duality.Vector3">
                    <X dataType="Float">0</X>
                    <Y dataType="Float">0</Y>
                    <Z dataType="Float">500</Z>
                  </posAbs>
                  <scale dataType="Float">1</scale>
                  <scaleAbs dataType="Float">1</scaleAbs>
                  <vel dataType="Struct" type="Duality.Vector3" />
                  <velAbs dataType="Struct" type="Duality.Vector3" />
                </item>
                <item dataType="Struct" type="Duality.Components.Camera" id="2421277785">
                  <active dataType="Bool">true</active>
                  <farZ dataType="Float">10000</farZ>
                  <focusDist dataType="Float">500</focusDist>
                  <gameobj dataType="ObjectRef">1884001978</gameobj>
                  <nearZ dataType="Float">0</nearZ>
                  <passes dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Components.Camera+Pass]]" id="3592906365">
                    <_items dataType="Array" type="Duality.Components.Camera+Pass[]" id="2515380006" length="4">
                      <item dataType="Struct" type="Duality.Components.Camera+Pass" id="1935705344">
                        <clearColor dataType="Struct" type="Duality.Drawing.ColorRgba" />
                        <clearDepth dataType="Float">1</clearDepth>
                        <clearFlags dataType="Enum" type="Duality.Drawing.ClearFlag" name="All" value="3" />
                        <input />
                        <matrixMode dataType="Enum" type="Duality.Drawing.RenderMatrix" name="PerspectiveWorld" value="0" />
                        <output dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.RenderTarget]]" />
                        <visibilityMask dataType="Enum" type="Duality.Drawing.VisibilityFlag" name="AllGroups" value="2147483647" />
                      </item>
                      <item dataType="Struct" type="Duality.Components.Camera+Pass" id="3313295822">
                        <clearColor dataType="Struct" type="Duality.Drawing.ColorRgba" />
                        <clearDepth dataType="Float">1</clearDepth>
                        <clearFlags dataType="Enum" type="Duality.Drawing.ClearFlag" name="None" value="0" />
                        <input />
                        <matrixMode dataType="Enum" type="Duality.Drawing.RenderMatrix" name="OrthoScreen" value="1" />
                        <output dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.RenderTarget]]" />
                        <visibilityMask dataType="Enum" type="Duality.Drawing.VisibilityFlag" name="All" value="4294967295" />
                      </item>
                    </_items>
                    <_size dataType="Int">2</_size>
                    <_version dataType="Int">2</_version>
                  </passes>
                  <perspective dataType="Enum" type="Duality.Drawing.PerspectiveMode" name="Parallax" value="1" />
                  <visibilityMask dataType="Enum" type="Duality.Drawing.VisibilityFlag" name="All" value="4294967295" />
                </item>
              </_items>
              <_size dataType="Int">2</_size>
              <_version dataType="Int">2</_version>
            </compList>
            <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="4213589258" surrogate="true">
              <header />
              <body>
                <keys dataType="Array" type="System.Object[]" id="2800066044">
                  <item dataType="Type" id="223898436" value="Duality.Components.Transform" />
                  <item dataType="Type" id="1392744086" value="Duality.Components.Camera" />
                </keys>
                <values dataType="Array" type="System.Object[]" id="97283990">
                  <item dataType="ObjectRef">4244316910</item>
                  <item dataType="ObjectRef">2421277785</item>
                </values>
              </body>
            </compMap>
            <compTransform dataType="ObjectRef">4244316910</compTransform>
            <identifier dataType="Struct" type="System.Guid" surrogate="true">
              <header>
                <data dataType="Array" type="System.Byte[]" id="2625220776">W9q9MfbdPEyoSJy6a57V3Q==</data>
              </header>
              <body />
            </identifier>
            <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
            <name dataType="String">MainCamera</name>
            <parent dataType="ObjectRef">1404595237</parent>
            <prefabLink />
          </item>
          <item dataType="Struct" type="Duality.GameObject" id="3092728469">
            <active dataType="Bool">true</active>
            <children />
            <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="402663701">
              <_items dataType="Array" type="Duality.Component[]" id="2263689334" length="4">
                <item dataType="Struct" type="CampGame.UI.UIRenderer" id="1179827591">
                  <_x003C_Material_x003E_k__BackingField dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Material]]" />
                  <_x003C_Offset_x003E_k__BackingField dataType="Struct" type="Duality.Vector2" />
                  <_x003C_Pos_x003E_k__BackingField dataType="Struct" type="Duality.Vector2">
                    <X dataType="Float">486</X>
                    <Y dataType="Float">794</Y>
                  </_x003C_Pos_x003E_k__BackingField>
                  <_x003C_Position_x003E_k__BackingField dataType="Enum" type="Duality.Alignment" name="Bottom" value="8" />
                  <_x003C_Size_x003E_k__BackingField dataType="Struct" type="Duality.Vector2">
                    <X dataType="Float">100</X>
                    <Y dataType="Float">100</Y>
                  </_x003C_Size_x003E_k__BackingField>
                  <_x003C_Visible_x003E_k__BackingField dataType="Bool">true</_x003C_Visible_x003E_k__BackingField>
                  <_x003C_ZOffset_x003E_k__BackingField dataType="Float">0</_x003C_ZOffset_x003E_k__BackingField>
                  <active dataType="Bool">true</active>
                  <gameobj dataType="ObjectRef">3092728469</gameobj>
                </item>
                <item dataType="Struct" type="CampGame.UI.UIPanelController" id="2753725314">
                  <active dataType="Bool">true</active>
                  <gameobj dataType="ObjectRef">3092728469</gameobj>
                </item>
              </_items>
              <_size dataType="Int">2</_size>
              <_version dataType="Int">8</_version>
            </compList>
            <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="3246766792" surrogate="true">
              <header />
              <body>
                <keys dataType="Array" type="System.Object[]" id="1053860031">
                  <item dataType="Type" id="4211306926" value="CampGame.UI.UIRenderer" />
                  <item dataType="Type" id="1917954762" value="CampGame.UI.UIPanelController" />
                </keys>
                <values dataType="Array" type="System.Object[]" id="921395680">
                  <item dataType="ObjectRef">1179827591</item>
                  <item dataType="ObjectRef">2753725314</item>
                </values>
              </body>
            </compMap>
            <compTransform />
            <identifier dataType="Struct" type="System.Guid" surrogate="true">
              <header>
                <data dataType="Array" type="System.Byte[]" id="1345210989">WAm13+ISAUOEnHUz+044zA==</data>
              </header>
              <body />
            </identifier>
            <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
            <name dataType="String">ToolsPanel</name>
            <parent dataType="ObjectRef">1404595237</parent>
            <prefabLink />
          </item>
        </_items>
        <_size dataType="Int">2</_size>
        <_version dataType="Int">4</_version>
      </children>
      <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="2587341760">
        <_items dataType="Array" type="Duality.Component[]" id="2205635805" length="4">
          <item dataType="ObjectRef">3764910169</item>
        </_items>
        <_size dataType="Int">1</_size>
        <_version dataType="Int">1</_version>
      </compList>
      <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="3301734517" surrogate="true">
        <header />
        <body>
          <keys dataType="Array" type="System.Object[]" id="2323399860">
            <item dataType="ObjectRef">223898436</item>
          </keys>
          <values dataType="Array" type="System.Object[]" id="2999308278">
            <item dataType="ObjectRef">3764910169</item>
          </values>
        </body>
      </compMap>
      <compTransform dataType="ObjectRef">3764910169</compTransform>
      <identifier dataType="Struct" type="System.Guid" surrogate="true">
        <header>
          <data dataType="Array" type="System.Byte[]" id="2347242256">VikVb63Kf0Wf8PajgtbEDA==</data>
        </header>
        <body />
      </identifier>
      <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
      <name dataType="String">UI</name>
      <parent />
      <prefabLink />
    </item>
    <item dataType="ObjectRef">1884001978</item>
    <item dataType="ObjectRef">3092728469</item>
  </serializeObj>
  <visibilityStrategy dataType="Struct" type="Duality.Components.DefaultRendererVisibilityStrategy" id="2035693768" />
</root>
<!-- XmlFormatterBase Document Separator -->
