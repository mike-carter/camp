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
        <_items dataType="Array" type="Duality.GameObject[]" id="2126658062">
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
                    <pos dataType="Struct" type="Duality.Vector3">
                      <X dataType="Float">1.1111145</X>
                      <Y dataType="Float">0</Y>
                      <Z dataType="Float">0</Z>
                    </pos>
                    <posAbs dataType="Struct" type="Duality.Vector3">
                      <X dataType="Float">1.1111145</X>
                      <Y dataType="Float">0</Y>
                      <Z dataType="Float">0</Z>
                    </posAbs>
                    <scale dataType="Float">1</scale>
                    <scaleAbs dataType="Float">1</scaleAbs>
                    <vel dataType="Struct" type="Duality.Vector3" />
                    <velAbs dataType="Struct" type="Duality.Vector3" />
                  </parentTransform>
                  <pos dataType="Struct" type="Duality.Vector3">
                    <X dataType="Float">0</X>
                    <Y dataType="Float">0</Y>
                    <Z dataType="Float">-500</Z>
                  </pos>
                  <posAbs dataType="Struct" type="Duality.Vector3">
                    <X dataType="Float">1.1111145</X>
                    <Y dataType="Float">0</Y>
                    <Z dataType="Float">-500</Z>
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
                  <perspective dataType="Enum" type="Duality.Drawing.PerspectiveMode" name="Flat" value="0" />
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
          <item dataType="Struct" type="Duality.GameObject" id="2458131936">
            <active dataType="Bool">true</active>
            <children dataType="Struct" type="System.Collections.Generic.List`1[[Duality.GameObject]]" id="672021676">
              <_items dataType="Array" type="Duality.GameObject[]" id="657996516" length="4" />
              <_size dataType="Int">0</_size>
              <_version dataType="Int">6</_version>
            </children>
            <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="3256571318">
              <_items dataType="Array" type="Duality.Component[]" id="3979189478" length="4">
                <item dataType="Struct" type="Duality.Components.Transform" id="523479572">
                  <active dataType="Bool">true</active>
                  <angle dataType="Float">0</angle>
                  <angleAbs dataType="Float">0</angleAbs>
                  <angleVel dataType="Float">0</angleVel>
                  <angleVelAbs dataType="Float">0</angleVelAbs>
                  <deriveAngle dataType="Bool">true</deriveAngle>
                  <gameobj dataType="ObjectRef">2458131936</gameobj>
                  <ignoreParent dataType="Bool">false</ignoreParent>
                  <parentTransform dataType="ObjectRef">3764910169</parentTransform>
                  <pos dataType="Struct" type="Duality.Vector3">
                    <X dataType="Float">-300</X>
                    <Y dataType="Float">367</Y>
                    <Z dataType="Float">0</Z>
                  </pos>
                  <posAbs dataType="Struct" type="Duality.Vector3">
                    <X dataType="Float">-298.8889</X>
                    <Y dataType="Float">367</Y>
                    <Z dataType="Float">0</Z>
                  </posAbs>
                  <scale dataType="Float">1</scale>
                  <scaleAbs dataType="Float">1</scaleAbs>
                  <vel dataType="Struct" type="Duality.Vector3" />
                  <velAbs dataType="Struct" type="Duality.Vector3" />
                </item>
                <item dataType="Struct" type="CampGame.UI.UIAlignedPanel" id="1019291613">
                  <_x003C_Offset_x003E_k__BackingField dataType="Struct" type="Duality.Vector2">
                    <X dataType="Float">0</X>
                    <Y dataType="Float">-20</Y>
                  </_x003C_Offset_x003E_k__BackingField>
                  <_x003C_ScreenAlignment_x003E_k__BackingField dataType="Enum" type="Duality.Alignment" name="Bottom" value="8" />
                  <active dataType="Bool">true</active>
                  <bgTint dataType="Struct" type="Duality.Drawing.ColorRgba">
                    <A dataType="Byte">255</A>
                    <B dataType="Byte">255</B>
                    <G dataType="Byte">255</G>
                    <R dataType="Byte">255</R>
                  </bgTint>
                  <borderAlign dataType="Enum" type="CampGame.UI.UIPanel+BorderAlign" name="Center" value="0" />
                  <bordersVisible dataType="Bool">true</bordersVisible>
                  <borderTint dataType="Struct" type="Duality.Drawing.ColorRgba">
                    <A dataType="Byte">255</A>
                    <B dataType="Byte">255</B>
                    <G dataType="Byte">255</G>
                    <R dataType="Byte">255</R>
                  </borderTint>
                  <borderWidths dataType="Struct" type="Duality.Vector4" />
                  <gameobj dataType="ObjectRef">2458131936</gameobj>
                  <isVisible dataType="Bool">true</isVisible>
                  <offset dataType="Int">0</offset>
                  <size dataType="Struct" type="Duality.Vector2">
                    <X dataType="Float">600</X>
                    <Y dataType="Float">60</Y>
                  </size>
                  <skin dataType="Struct" type="Duality.ContentRef`1[[CampGame.UI.UISkin]]">
                    <contentPath dataType="String">Data\UI\panel-skin.UISkin.res</contentPath>
                  </skin>
                  <useCustomWidths dataType="Bool">false</useCustomWidths>
                  <visibilityGroup dataType="Enum" type="Duality.Drawing.VisibilityFlag" name="AllFlags" value="2147483648" />
                </item>
              </_items>
              <_size dataType="Int">2</_size>
              <_version dataType="Int">6</_version>
            </compList>
            <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="4123556600" surrogate="true">
              <header />
              <body>
                <keys dataType="Array" type="System.Object[]" id="1195475704">
                  <item dataType="ObjectRef">223898436</item>
                  <item dataType="Type" id="4203713388" value="CampGame.UI.UIAlignedPanel" />
                </keys>
                <values dataType="Array" type="System.Object[]" id="241016798">
                  <item dataType="ObjectRef">523479572</item>
                  <item dataType="ObjectRef">1019291613</item>
                </values>
              </body>
            </compMap>
            <compTransform dataType="ObjectRef">523479572</compTransform>
            <identifier dataType="Struct" type="System.Guid" surrogate="true">
              <header>
                <data dataType="Array" type="System.Byte[]" id="1641279908">P1QREJUj00mkdaERgzASDA==</data>
              </header>
              <body />
            </identifier>
            <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
            <name dataType="String">ToolPanel</name>
            <parent dataType="ObjectRef">1404595237</parent>
            <prefabLink />
          </item>
          <item dataType="Struct" type="Duality.GameObject" id="3998162807">
            <active dataType="Bool">true</active>
            <children />
            <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="3294531719">
              <_items dataType="Array" type="Duality.Component[]" id="3816154958" length="4">
                <item dataType="Struct" type="Duality.Components.Transform" id="2063510443">
                  <active dataType="Bool">true</active>
                  <angle dataType="Float">0</angle>
                  <angleAbs dataType="Float">0</angleAbs>
                  <angleVel dataType="Float">0</angleVel>
                  <angleVelAbs dataType="Float">0</angleVelAbs>
                  <deriveAngle dataType="Bool">true</deriveAngle>
                  <gameobj dataType="ObjectRef">3998162807</gameobj>
                  <ignoreParent dataType="Bool">false</ignoreParent>
                  <parentTransform dataType="ObjectRef">3764910169</parentTransform>
                  <pos dataType="Struct" type="Duality.Vector3">
                    <X dataType="Float">-339.5</X>
                    <Y dataType="Float">-447</Y>
                    <Z dataType="Float">0</Z>
                  </pos>
                  <posAbs dataType="Struct" type="Duality.Vector3">
                    <X dataType="Float">-338.3889</X>
                    <Y dataType="Float">-447</Y>
                    <Z dataType="Float">0</Z>
                  </posAbs>
                  <scale dataType="Float">1</scale>
                  <scaleAbs dataType="Float">1</scaleAbs>
                  <vel dataType="Struct" type="Duality.Vector3" />
                  <velAbs dataType="Struct" type="Duality.Vector3" />
                </item>
                <item dataType="Struct" type="CampGame.UI.UICursor" id="748195236">
                  <active dataType="Bool">true</active>
                  <bgTint dataType="Struct" type="Duality.Drawing.ColorRgba">
                    <A dataType="Byte">255</A>
                    <B dataType="Byte">255</B>
                    <G dataType="Byte">255</G>
                    <R dataType="Byte">255</R>
                  </bgTint>
                  <borderAlign dataType="Enum" type="CampGame.UI.UIPanel+BorderAlign" name="Center" value="0" />
                  <bordersVisible dataType="Bool">false</bordersVisible>
                  <borderTint dataType="Struct" type="Duality.Drawing.ColorRgba">
                    <A dataType="Byte">255</A>
                    <B dataType="Byte">255</B>
                    <G dataType="Byte">255</G>
                    <R dataType="Byte">255</R>
                  </borderTint>
                  <borderWidths dataType="Struct" type="Duality.Vector4" />
                  <gameobj dataType="ObjectRef">3998162807</gameobj>
                  <isVisible dataType="Bool">true</isVisible>
                  <offset dataType="Int">0</offset>
                  <size dataType="Struct" type="Duality.Vector2">
                    <X dataType="Float">20</X>
                    <Y dataType="Float">23</Y>
                  </size>
                  <skin dataType="Struct" type="Duality.ContentRef`1[[CampGame.UI.UISkin]]">
                    <contentPath dataType="String">Data\UI\cursor-skin.UISkin.res</contentPath>
                  </skin>
                  <useCustomWidths dataType="Bool">false</useCustomWidths>
                  <visibilityGroup dataType="Enum" type="Duality.Drawing.VisibilityFlag" name="AllFlags" value="2147483648" />
                </item>
              </_items>
              <_size dataType="Int">2</_size>
              <_version dataType="Int">8</_version>
            </compList>
            <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="618703232" surrogate="true">
              <header />
              <body>
                <keys dataType="Array" type="System.Object[]" id="2546321709">
                  <item dataType="ObjectRef">223898436</item>
                  <item dataType="Type" id="1490683494" value="CampGame.UI.UICursor" />
                </keys>
                <values dataType="Array" type="System.Object[]" id="3194460792">
                  <item dataType="ObjectRef">2063510443</item>
                  <item dataType="ObjectRef">748195236</item>
                </values>
              </body>
            </compMap>
            <compTransform dataType="ObjectRef">2063510443</compTransform>
            <identifier dataType="Struct" type="System.Guid" surrogate="true">
              <header>
                <data dataType="Array" type="System.Byte[]" id="2668952903">ElhXPhjkv0eHVjRXaHQ02g==</data>
              </header>
              <body />
            </identifier>
            <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
            <name dataType="String">Cursor</name>
            <parent dataType="ObjectRef">1404595237</parent>
            <prefabLink />
          </item>
          <item dataType="Struct" type="Duality.GameObject" id="2726180495">
            <active dataType="Bool">true</active>
            <children dataType="Struct" type="System.Collections.Generic.List`1[[Duality.GameObject]]" id="3011966911">
              <_items dataType="Array" type="Duality.GameObject[]" id="2797235630" length="4">
                <item dataType="Struct" type="Duality.GameObject" id="3241605610">
                  <active dataType="Bool">true</active>
                  <children />
                  <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="3035932974">
                    <_items dataType="Array" type="Duality.Component[]" id="1017579344" length="0" />
                    <_size dataType="Int">0</_size>
                    <_version dataType="Int">0</_version>
                  </compList>
                  <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="476692682" surrogate="true">
                    <header />
                    <body>
                      <keys dataType="Array" type="System.Object[]" id="2899336108" length="0" />
                      <values dataType="Array" type="System.Object[]" id="2505659318" length="0" />
                    </body>
                  </compMap>
                  <compTransform />
                  <identifier dataType="Struct" type="System.Guid" surrogate="true">
                    <header>
                      <data dataType="Array" type="System.Byte[]" id="1960893432">8L8nyRGQ9UaI5Zge9A9S7w==</data>
                    </header>
                    <body />
                  </identifier>
                  <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                  <name dataType="String">LeftScrollButton</name>
                  <parent dataType="ObjectRef">2726180495</parent>
                  <prefabLink />
                </item>
                <item dataType="Struct" type="Duality.GameObject" id="2774209063">
                  <active dataType="Bool">true</active>
                  <children />
                  <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="3430543447">
                    <_items dataType="ObjectRef">1017579344</_items>
                    <_size dataType="Int">0</_size>
                    <_version dataType="Int">0</_version>
                  </compList>
                  <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="838298560" surrogate="true">
                    <header />
                    <body>
                      <keys dataType="Array" type="System.Object[]" id="774484189" length="0" />
                      <values dataType="Array" type="System.Object[]" id="2380432504" length="0" />
                    </body>
                  </compMap>
                  <compTransform />
                  <identifier dataType="Struct" type="System.Guid" surrogate="true">
                    <header>
                      <data dataType="Array" type="System.Byte[]" id="1002009719">QF7I6JPU2Uy6f5l3lVjEvg==</data>
                    </header>
                    <body />
                  </identifier>
                  <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                  <name dataType="String">RightScrollButton</name>
                  <parent dataType="ObjectRef">2726180495</parent>
                  <prefabLink />
                </item>
              </_items>
              <_size dataType="Int">2</_size>
              <_version dataType="Int">2</_version>
            </children>
            <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="1404161504">
              <_items dataType="Array" type="Duality.Component[]" id="1996368501" length="4">
                <item dataType="Struct" type="Duality.Components.Transform" id="791528131">
                  <active dataType="Bool">true</active>
                  <angle dataType="Float">0</angle>
                  <angleAbs dataType="Float">0</angleAbs>
                  <angleVel dataType="Float">0</angleVel>
                  <angleVelAbs dataType="Float">0</angleVelAbs>
                  <deriveAngle dataType="Bool">true</deriveAngle>
                  <gameobj dataType="ObjectRef">2726180495</gameobj>
                  <ignoreParent dataType="Bool">false</ignoreParent>
                  <parentTransform dataType="ObjectRef">3764910169</parentTransform>
                  <pos dataType="Struct" type="Duality.Vector3">
                    <X dataType="Float">-56.66667</X>
                    <Y dataType="Float">296.6667</Y>
                    <Z dataType="Float">0</Z>
                  </pos>
                  <posAbs dataType="Struct" type="Duality.Vector3">
                    <X dataType="Float">-55.5555573</X>
                    <Y dataType="Float">296.6667</Y>
                    <Z dataType="Float">0</Z>
                  </posAbs>
                  <scale dataType="Float">1</scale>
                  <scaleAbs dataType="Float">1</scaleAbs>
                  <vel dataType="Struct" type="Duality.Vector3" />
                  <velAbs dataType="Struct" type="Duality.Vector3" />
                </item>
              </_items>
              <_size dataType="Int">1</_size>
              <_version dataType="Int">3</_version>
            </compList>
            <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="2697831789" surrogate="true">
              <header />
              <body>
                <keys dataType="Array" type="System.Object[]" id="3943089956">
                  <item dataType="ObjectRef">223898436</item>
                </keys>
                <values dataType="Array" type="System.Object[]" id="487430422">
                  <item dataType="ObjectRef">791528131</item>
                </values>
              </body>
            </compMap>
            <compTransform dataType="ObjectRef">791528131</compTransform>
            <identifier dataType="Struct" type="System.Guid" surrogate="true">
              <header>
                <data dataType="Array" type="System.Byte[]" id="377714976">bnP7BIVDH0WlReUsrHeS/g==</data>
              </header>
              <body />
            </identifier>
            <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
            <name dataType="String">BuildPanel</name>
            <parent dataType="ObjectRef">1404595237</parent>
            <prefabLink />
          </item>
        </_items>
        <_size dataType="Int">4</_size>
        <_version dataType="Int">16</_version>
      </children>
      <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="2587341760">
        <_items dataType="Array" type="Duality.Component[]" id="2205635805" length="4">
          <item dataType="ObjectRef">3764910169</item>
          <item dataType="Struct" type="CampGame.CameraControl.KeyboardControlComponent" id="897859155">
            <_x003C_CrosshairSize_x003E_k__BackingField dataType="Float">32</_x003C_CrosshairSize_x003E_k__BackingField>
            <_x003C_ShowPosition_x003E_k__BackingField dataType="Bool">false</_x003C_ShowPosition_x003E_k__BackingField>
            <_x003C_Speed_x003E_k__BackingField dataType="Float">10</_x003C_Speed_x003E_k__BackingField>
            <active dataType="Bool">true</active>
            <gameobj dataType="ObjectRef">1404595237</gameobj>
          </item>
          <item dataType="Struct" type="CampGame.UI.UIInputManager" id="1556374447">
            <active dataType="Bool">true</active>
            <gameobj dataType="ObjectRef">1404595237</gameobj>
          </item>
        </_items>
        <_size dataType="Int">3</_size>
        <_version dataType="Int">5</_version>
      </compList>
      <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="3301734517" surrogate="true">
        <header />
        <body>
          <keys dataType="Array" type="System.Object[]" id="2323399860">
            <item dataType="ObjectRef">223898436</item>
            <item dataType="Type" id="39419300" value="CampGame.CameraControl.KeyboardControlComponent" />
            <item dataType="Type" id="1487714070" value="CampGame.UI.UIInputManager" />
          </keys>
          <values dataType="Array" type="System.Object[]" id="2999308278">
            <item dataType="ObjectRef">3764910169</item>
            <item dataType="ObjectRef">897859155</item>
            <item dataType="ObjectRef">1556374447</item>
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
    <item dataType="Struct" type="Duality.GameObject" id="1761944324">
      <active dataType="Bool">true</active>
      <children dataType="Struct" type="System.Collections.Generic.List`1[[Duality.GameObject]]" id="3369170362">
        <_items dataType="Array" type="Duality.GameObject[]" id="2432180224" length="4">
          <item dataType="Struct" type="Duality.GameObject" id="2139165483">
            <active dataType="Bool">true</active>
            <children />
            <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="689761567">
              <_items dataType="Array" type="Duality.Component[]" id="2166066030" length="4">
                <item dataType="Struct" type="Duality.Plugins.Tilemaps.Tilemap" id="4141017500">
                  <active dataType="Bool">true</active>
                  <gameobj dataType="ObjectRef">2139165483</gameobj>
                  <tileData dataType="Struct" type="Duality.Plugins.Tilemaps.TilemapData" id="1622319624" custom="true">
                    <body>
                      <version dataType="Int">2</version>
                      <data dataType="Array" type="System.Byte[]" id="3724592492">H4sIAAAAAAAEAO3BgQAAAAjAsEMEkD9lIG3bagIAAIAfDkqKlEwIDwAA</data>
                    </body>
                  </tileData>
                  <tileset dataType="Struct" type="Duality.ContentRef`1[[Duality.Plugins.Tilemaps.Tileset]]">
                    <contentPath dataType="String">Data\Map\MagicTown.Tileset.res</contentPath>
                  </tileset>
                </item>
                <item dataType="Struct" type="Duality.Components.Transform" id="204513119">
                  <active dataType="Bool">true</active>
                  <angle dataType="Float">0</angle>
                  <angleAbs dataType="Float">0</angleAbs>
                  <angleVel dataType="Float">0</angleVel>
                  <angleVelAbs dataType="Float">0</angleVelAbs>
                  <deriveAngle dataType="Bool">true</deriveAngle>
                  <gameobj dataType="ObjectRef">2139165483</gameobj>
                  <ignoreParent dataType="Bool">false</ignoreParent>
                  <parentTransform />
                  <pos dataType="Struct" type="Duality.Vector3" />
                  <posAbs dataType="Struct" type="Duality.Vector3" />
                  <scale dataType="Float">1</scale>
                  <scaleAbs dataType="Float">1</scaleAbs>
                  <vel dataType="Struct" type="Duality.Vector3" />
                  <velAbs dataType="Struct" type="Duality.Vector3" />
                </item>
                <item dataType="Struct" type="Duality.Plugins.Tilemaps.TilemapRenderer" id="837273635">
                  <active dataType="Bool">true</active>
                  <colorTint dataType="Struct" type="Duality.Drawing.ColorRgba">
                    <A dataType="Byte">255</A>
                    <B dataType="Byte">255</B>
                    <G dataType="Byte">255</G>
                    <R dataType="Byte">255</R>
                  </colorTint>
                  <externalTilemap />
                  <gameobj dataType="ObjectRef">2139165483</gameobj>
                  <offset dataType="Float">0</offset>
                  <origin dataType="Enum" type="Duality.Alignment" name="Center" value="0" />
                  <tileDepthMode dataType="Enum" type="Duality.Plugins.Tilemaps.TileDepthOffsetMode" name="Local" value="1" />
                  <tileDepthOffset dataType="Int">0</tileDepthOffset>
                  <tileDepthScale dataType="Float">0.01</tileDepthScale>
                  <visibilityGroup dataType="Enum" type="Duality.Drawing.VisibilityFlag" name="Group0" value="1" />
                </item>
              </_items>
              <_size dataType="Int">3</_size>
              <_version dataType="Int">3</_version>
            </compList>
            <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="1040567840" surrogate="true">
              <header />
              <body>
                <keys dataType="Array" type="System.Object[]" id="3259493525">
                  <item dataType="Type" id="2553367670" value="Duality.Plugins.Tilemaps.Tilemap" />
                  <item dataType="ObjectRef">223898436</item>
                  <item dataType="Type" id="1916522778" value="Duality.Plugins.Tilemaps.TilemapRenderer" />
                </keys>
                <values dataType="Array" type="System.Object[]" id="1135333064">
                  <item dataType="ObjectRef">4141017500</item>
                  <item dataType="ObjectRef">204513119</item>
                  <item dataType="ObjectRef">837273635</item>
                </values>
              </body>
            </compMap>
            <compTransform dataType="ObjectRef">204513119</compTransform>
            <identifier dataType="Struct" type="System.Guid" surrogate="true">
              <header>
                <data dataType="Array" type="System.Byte[]" id="1960791967">wFgupq/2M0uZ6S96daX92A==</data>
              </header>
              <body />
            </identifier>
            <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
            <name dataType="String">BaseLayer</name>
            <parent dataType="ObjectRef">1761944324</parent>
            <prefabLink />
          </item>
          <item dataType="Struct" type="Duality.GameObject" id="230574299">
            <active dataType="Bool">true</active>
            <children />
            <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="117088751">
              <_items dataType="Array" type="Duality.Component[]" id="3290578158" length="4">
                <item dataType="Struct" type="Duality.Plugins.Tilemaps.Tilemap" id="2232426316">
                  <active dataType="Bool">true</active>
                  <gameobj dataType="ObjectRef">230574299</gameobj>
                  <tileData dataType="Struct" type="Duality.Plugins.Tilemaps.TilemapData" id="835351640" custom="true">
                    <body>
                      <version dataType="Int">2</version>
                      <data dataType="Array" type="System.Byte[]" id="4142252716">H4sIAAAAAAAEAO3UOw6CUBCF4VkECwArdEvEXSg2PhrBRrDxsRW1UxthVZqf5iZmEuyGZIr7NfcUZ4qZWESi75uKuK7rDshM0UK3Pl7xFnhXkjOcY44LA/3f+MIHPpXkEle4xo2B/nEwRYOtktxigSXuDPRPgykSHCnJPVZY48FA/3CKMU5+fruNPuIJz3gx0LyP9i+SdkWHeFFd13X/9QM5v+jjCA8AAA==</data>
                    </body>
                  </tileData>
                  <tileset dataType="Struct" type="Duality.ContentRef`1[[Duality.Plugins.Tilemaps.Tileset]]">
                    <contentPath dataType="String">Data\Map\MagicTown.Tileset.res</contentPath>
                  </tileset>
                </item>
                <item dataType="Struct" type="Duality.Components.Transform" id="2590889231">
                  <active dataType="Bool">true</active>
                  <angle dataType="Float">0</angle>
                  <angleAbs dataType="Float">0</angleAbs>
                  <angleVel dataType="Float">0</angleVel>
                  <angleVelAbs dataType="Float">0</angleVelAbs>
                  <deriveAngle dataType="Bool">true</deriveAngle>
                  <gameobj dataType="ObjectRef">230574299</gameobj>
                  <ignoreParent dataType="Bool">false</ignoreParent>
                  <parentTransform />
                  <pos dataType="Struct" type="Duality.Vector3" />
                  <posAbs dataType="Struct" type="Duality.Vector3" />
                  <scale dataType="Float">1</scale>
                  <scaleAbs dataType="Float">1</scaleAbs>
                  <vel dataType="Struct" type="Duality.Vector3" />
                  <velAbs dataType="Struct" type="Duality.Vector3" />
                </item>
                <item dataType="Struct" type="Duality.Plugins.Tilemaps.TilemapRenderer" id="3223649747">
                  <active dataType="Bool">true</active>
                  <colorTint dataType="Struct" type="Duality.Drawing.ColorRgba">
                    <A dataType="Byte">255</A>
                    <B dataType="Byte">255</B>
                    <G dataType="Byte">255</G>
                    <R dataType="Byte">255</R>
                  </colorTint>
                  <externalTilemap />
                  <gameobj dataType="ObjectRef">230574299</gameobj>
                  <offset dataType="Float">-0.01</offset>
                  <origin dataType="Enum" type="Duality.Alignment" name="Center" value="0" />
                  <tileDepthMode dataType="Enum" type="Duality.Plugins.Tilemaps.TileDepthOffsetMode" name="Local" value="1" />
                  <tileDepthOffset dataType="Int">0</tileDepthOffset>
                  <tileDepthScale dataType="Float">0.01</tileDepthScale>
                  <visibilityGroup dataType="Enum" type="Duality.Drawing.VisibilityFlag" name="Group0" value="1" />
                </item>
              </_items>
              <_size dataType="Int">3</_size>
              <_version dataType="Int">3</_version>
            </compList>
            <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="944337312" surrogate="true">
              <header />
              <body>
                <keys dataType="Array" type="System.Object[]" id="2012001349">
                  <item dataType="ObjectRef">2553367670</item>
                  <item dataType="ObjectRef">223898436</item>
                  <item dataType="ObjectRef">1916522778</item>
                </keys>
                <values dataType="Array" type="System.Object[]" id="431241256">
                  <item dataType="ObjectRef">2232426316</item>
                  <item dataType="ObjectRef">2590889231</item>
                  <item dataType="ObjectRef">3223649747</item>
                </values>
              </body>
            </compMap>
            <compTransform dataType="ObjectRef">2590889231</compTransform>
            <identifier dataType="Struct" type="System.Guid" surrogate="true">
              <header>
                <data dataType="Array" type="System.Byte[]" id="3017132495">8ggiNJydUkCaiKSaIvkhew==</data>
              </header>
              <body />
            </identifier>
            <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
            <name dataType="String">StructureLayer</name>
            <parent dataType="ObjectRef">1761944324</parent>
            <prefabLink />
          </item>
          <item dataType="Struct" type="Duality.GameObject" id="4000662451">
            <active dataType="Bool">true</active>
            <children />
            <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="3354613703">
              <_items dataType="Array" type="Duality.Component[]" id="4020734158" length="4">
                <item dataType="Struct" type="Duality.Plugins.Tilemaps.Tilemap" id="1707547172">
                  <active dataType="Bool">true</active>
                  <gameobj dataType="ObjectRef">4000662451</gameobj>
                  <tileData dataType="Struct" type="Duality.Plugins.Tilemaps.TilemapData" id="2014668208" custom="true">
                    <body>
                      <version dataType="Int">2</version>
                      <data dataType="Array" type="System.Byte[]" id="3233902012">H4sIAAAAAAAEAO3BgQAAAAjAsEMEkD9lIG3bagIAAIAfDkqKlEwIDwAA</data>
                    </body>
                  </tileData>
                  <tileset dataType="Struct" type="Duality.ContentRef`1[[Duality.Plugins.Tilemaps.Tileset]]" />
                </item>
              </_items>
              <_size dataType="Int">1</_size>
              <_version dataType="Int">1</_version>
            </compList>
            <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="2583027968" surrogate="true">
              <header />
              <body>
                <keys dataType="Array" type="System.Object[]" id="1221785709">
                  <item dataType="ObjectRef">2553367670</item>
                </keys>
                <values dataType="Array" type="System.Object[]" id="1323243256">
                  <item dataType="ObjectRef">1707547172</item>
                </values>
              </body>
            </compMap>
            <compTransform />
            <identifier dataType="Struct" type="System.Guid" surrogate="true">
              <header>
                <data dataType="Array" type="System.Byte[]" id="4153408391">bgH4so2i1kKrJf5LbDbCCw==</data>
              </header>
              <body />
            </identifier>
            <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
            <name dataType="String">BuildLayer</name>
            <parent dataType="ObjectRef">1761944324</parent>
            <prefabLink />
          </item>
        </_items>
        <_size dataType="Int">3</_size>
        <_version dataType="Int">3</_version>
      </children>
      <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="687869370">
        <_items dataType="Array" type="Duality.Component[]" id="2740758528" length="4" />
        <_size dataType="Int">0</_size>
        <_version dataType="Int">8</_version>
      </compList>
      <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="3791836602" surrogate="true">
        <header />
        <body>
          <keys dataType="Array" type="System.Object[]" id="4099457024" length="0" />
          <values dataType="Array" type="System.Object[]" id="2785229774" length="0" />
        </body>
      </compMap>
      <compTransform />
      <identifier dataType="Struct" type="System.Guid" surrogate="true">
        <header>
          <data dataType="Array" type="System.Byte[]" id="3111082140">u27HP8JdeE2jagsA6uX4xw==</data>
        </header>
        <body />
      </identifier>
      <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
      <name dataType="String">Map</name>
      <parent />
      <prefabLink />
    </item>
    <item dataType="Struct" type="Duality.GameObject" id="3065139288">
      <active dataType="Bool">true</active>
      <children dataType="Struct" type="System.Collections.Generic.List`1[[Duality.GameObject]]" id="2016797886">
        <_items dataType="Array" type="Duality.GameObject[]" id="348699664" length="4">
          <item dataType="Struct" type="Duality.GameObject" id="3725137910">
            <active dataType="Bool">true</active>
            <children dataType="Struct" type="System.Collections.Generic.List`1[[Duality.GameObject]]" id="2440889462">
              <_items dataType="Array" type="Duality.GameObject[]" id="2724597728" length="4">
                <item dataType="Struct" type="Duality.GameObject" id="200322058">
                  <active dataType="Bool">true</active>
                  <children />
                  <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="2431126722">
                    <_items dataType="Array" type="Duality.Component[]" id="4132345360" length="0" />
                    <_size dataType="Int">0</_size>
                    <_version dataType="Int">0</_version>
                  </compList>
                  <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="3297408522" surrogate="true">
                    <header />
                    <body>
                      <keys dataType="Array" type="System.Object[]" id="4010484888" length="0" />
                      <values dataType="Array" type="System.Object[]" id="3960804638" length="0" />
                    </body>
                  </compMap>
                  <compTransform />
                  <identifier dataType="Struct" type="System.Guid" surrogate="true">
                    <header>
                      <data dataType="Array" type="System.Byte[]" id="4155891396">Teupk1k9L0eNd6WQNbmFaA==</data>
                    </header>
                    <body />
                  </identifier>
                  <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                  <name dataType="String">DemoBuilding</name>
                  <parent dataType="ObjectRef">3725137910</parent>
                  <prefabLink />
                </item>
                <item dataType="Struct" type="Duality.GameObject" id="2881981462">
                  <active dataType="Bool">true</active>
                  <children />
                  <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="1117736950">
                    <_items dataType="ObjectRef">4132345360</_items>
                    <_size dataType="Int">0</_size>
                    <_version dataType="Int">0</_version>
                  </compList>
                  <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="2826994714" surrogate="true">
                    <header />
                    <body>
                      <keys dataType="Array" type="System.Object[]" id="4065036996" length="0" />
                      <values dataType="Array" type="System.Object[]" id="41603990" length="0" />
                    </body>
                  </compMap>
                  <compTransform />
                  <identifier dataType="Struct" type="System.Guid" surrogate="true">
                    <header>
                      <data dataType="Array" type="System.Byte[]" id="3538184064">B8eL1UyUJUunYupDoEdLNA==</data>
                    </header>
                    <body />
                  </identifier>
                  <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                  <name dataType="String">DemoTree</name>
                  <parent dataType="ObjectRef">3725137910</parent>
                  <prefabLink />
                </item>
              </_items>
              <_size dataType="Int">2</_size>
              <_version dataType="Int">2</_version>
            </children>
            <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="2067296538">
              <_items dataType="Array" type="Duality.Component[]" id="535075652" length="0" />
              <_size dataType="Int">0</_size>
              <_version dataType="Int">0</_version>
            </compList>
            <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="3181608854" surrogate="true">
              <header />
              <body>
                <keys dataType="Array" type="System.Object[]" id="1376886208" length="0" />
                <values dataType="Array" type="System.Object[]" id="1972790350" length="0" />
              </body>
            </compMap>
            <compTransform />
            <identifier dataType="Struct" type="System.Guid" surrogate="true">
              <header>
                <data dataType="Array" type="System.Byte[]" id="332290396">W1vr3eKUWUyEupei/jRG9A==</data>
              </header>
              <body />
            </identifier>
            <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
            <name dataType="String">Structures</name>
            <parent dataType="ObjectRef">3065139288</parent>
            <prefabLink />
          </item>
          <item dataType="Struct" type="Duality.GameObject" id="4197034636">
            <active dataType="Bool">true</active>
            <children />
            <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="59989940">
              <_items dataType="ObjectRef">535075652</_items>
              <_size dataType="Int">0</_size>
              <_version dataType="Int">0</_version>
            </compList>
            <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="3973711350" surrogate="true">
              <header />
              <body>
                <keys dataType="Array" type="System.Object[]" id="1996178078" length="0" />
                <values dataType="Array" type="System.Object[]" id="1121723786" length="0" />
              </body>
            </compMap>
            <compTransform />
            <identifier dataType="Struct" type="System.Guid" surrogate="true">
              <header>
                <data dataType="Array" type="System.Byte[]" id="104649070">lOlolEGzCkO+Xd142146Eg==</data>
              </header>
              <body />
            </identifier>
            <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
            <name dataType="String">Paths</name>
            <parent dataType="ObjectRef">3065139288</parent>
            <prefabLink />
          </item>
        </_items>
        <_size dataType="Int">2</_size>
        <_version dataType="Int">4</_version>
      </children>
      <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="3599069194">
        <_items dataType="ObjectRef">535075652</_items>
        <_size dataType="Int">0</_size>
        <_version dataType="Int">0</_version>
      </compList>
      <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="41976526" surrogate="true">
        <header />
        <body>
          <keys dataType="Array" type="System.Object[]" id="2961029536" length="0" />
          <values dataType="Array" type="System.Object[]" id="2835947150" length="0" />
        </body>
      </compMap>
      <compTransform />
      <identifier dataType="Struct" type="System.Guid" surrogate="true">
        <header>
          <data dataType="Array" type="System.Byte[]" id="3664838076">mB9podvRQU+wxsaPS799gQ==</data>
        </header>
        <body />
      </identifier>
      <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
      <name dataType="String">Objects</name>
      <parent />
      <prefabLink />
    </item>
    <item dataType="ObjectRef">1884001978</item>
    <item dataType="ObjectRef">2458131936</item>
    <item dataType="ObjectRef">3998162807</item>
    <item dataType="ObjectRef">2726180495</item>
    <item dataType="ObjectRef">2139165483</item>
    <item dataType="ObjectRef">230574299</item>
    <item dataType="ObjectRef">4000662451</item>
    <item dataType="ObjectRef">3725137910</item>
    <item dataType="ObjectRef">4197034636</item>
    <item dataType="ObjectRef">3241605610</item>
    <item dataType="ObjectRef">2774209063</item>
    <item dataType="ObjectRef">200322058</item>
    <item dataType="ObjectRef">2881981462</item>
  </serializeObj>
  <visibilityStrategy dataType="Struct" type="Duality.Components.DefaultRendererVisibilityStrategy" id="2035693768" />
</root>
<!-- XmlFormatterBase Document Separator -->
