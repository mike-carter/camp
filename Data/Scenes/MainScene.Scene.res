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
              <_items dataType="Array" type="Duality.GameObject[]" id="657996516" length="4">
                <item dataType="Struct" type="Duality.GameObject" id="2955533795">
                  <active dataType="Bool">true</active>
                  <children />
                  <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="1353070095">
                    <_items dataType="Array" type="Duality.Component[]" id="202040238" length="4">
                      <item dataType="Struct" type="Duality.Components.Transform" id="1020881431">
                        <active dataType="Bool">true</active>
                        <angle dataType="Float">0</angle>
                        <angleAbs dataType="Float">0</angleAbs>
                        <angleVel dataType="Float">0</angleVel>
                        <angleVelAbs dataType="Float">0</angleVelAbs>
                        <deriveAngle dataType="Bool">true</deriveAngle>
                        <gameobj dataType="ObjectRef">2955533795</gameobj>
                        <ignoreParent dataType="Bool">false</ignoreParent>
                        <parentTransform dataType="Struct" type="Duality.Components.Transform" id="523479572">
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
                            <X dataType="Float">-334.444458</X>
                            <Y dataType="Float">385.555573</Y>
                            <Z dataType="Float">0</Z>
                          </pos>
                          <posAbs dataType="Struct" type="Duality.Vector3">
                            <X dataType="Float">-333.333344</X>
                            <Y dataType="Float">385.555573</Y>
                            <Z dataType="Float">0</Z>
                          </posAbs>
                          <scale dataType="Float">1</scale>
                          <scaleAbs dataType="Float">1</scaleAbs>
                          <vel dataType="Struct" type="Duality.Vector3" />
                          <velAbs dataType="Struct" type="Duality.Vector3" />
                        </parentTransform>
                        <pos dataType="Struct" type="Duality.Vector3">
                          <X dataType="Float">23.7878723</X>
                          <Y dataType="Float">28.3332214</Y>
                          <Z dataType="Float">0</Z>
                        </pos>
                        <posAbs dataType="Struct" type="Duality.Vector3">
                          <X dataType="Float">-309.545471</X>
                          <Y dataType="Float">413.8888</Y>
                          <Z dataType="Float">0</Z>
                        </posAbs>
                        <scale dataType="Float">0.2130684</scale>
                        <scaleAbs dataType="Float">0.2130684</scaleAbs>
                        <vel dataType="Struct" type="Duality.Vector3" />
                        <velAbs dataType="Struct" type="Duality.Vector3" />
                      </item>
                      <item dataType="Struct" type="CampGame.UI.ToolPanelButton" id="1136735570">
                        <_x003C_BaseMaterial_x003E_k__BackingField dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Material]]">
                          <contentPath dataType="String">Data\UI\ButtonIcons\buildIcon.Material.res</contentPath>
                        </_x003C_BaseMaterial_x003E_k__BackingField>
                        <_x003C_ButtonID_x003E_k__BackingField dataType="Enum" type="CampGame.UI.ToolPanelButton+Button" name="None" value="0" />
                        <_x003C_ZOffset_x003E_k__BackingField dataType="Float">50</_x003C_ZOffset_x003E_k__BackingField>
                        <active dataType="Bool">true</active>
                        <gameobj dataType="ObjectRef">2955533795</gameobj>
                        <widgetArea dataType="Struct" type="Duality.Rect">
                          <H dataType="Float">40</H>
                          <W dataType="Float">40</W>
                          <X dataType="Float">0</X>
                          <Y dataType="Float">0</Y>
                        </widgetArea>
                      </item>
                    </_items>
                    <_size dataType="Int">2</_size>
                    <_version dataType="Int">4</_version>
                  </compList>
                  <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="4104224736" surrogate="true">
                    <header />
                    <body>
                      <keys dataType="Array" type="System.Object[]" id="3460156837">
                        <item dataType="ObjectRef">223898436</item>
                        <item dataType="Type" id="2931362198" value="CampGame.UI.ToolPanelButton" />
                      </keys>
                      <values dataType="Array" type="System.Object[]" id="3527919720">
                        <item dataType="ObjectRef">1020881431</item>
                        <item dataType="ObjectRef">1136735570</item>
                      </values>
                    </body>
                  </compMap>
                  <compTransform dataType="ObjectRef">1020881431</compTransform>
                  <identifier dataType="Struct" type="System.Guid" surrogate="true">
                    <header>
                      <data dataType="Array" type="System.Byte[]" id="2163203183">Lp7K++MMU0O+q0cx1CJIng==</data>
                    </header>
                    <body />
                  </identifier>
                  <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                  <name dataType="String">buildButton</name>
                  <parent dataType="ObjectRef">2458131936</parent>
                  <prefabLink />
                </item>
              </_items>
              <_size dataType="Int">1</_size>
              <_version dataType="Int">3</_version>
            </children>
            <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="3256571318">
              <_items dataType="Array" type="Duality.Component[]" id="3979189478" length="4">
                <item dataType="ObjectRef">523479572</item>
                <item dataType="Struct" type="CampGame.UI.UIPanel" id="455882537">
                  <_x003C_BaseMaterial_x003E_k__BackingField dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Material]]">
                    <contentPath dataType="String">Data\UI\Materials\toolbar.Material.res</contentPath>
                  </_x003C_BaseMaterial_x003E_k__BackingField>
                  <_x003C_Offset_x003E_k__BackingField dataType="Struct" type="Duality.Vector2" />
                  <_x003C_ScreenAlignment_x003E_k__BackingField dataType="Enum" type="Duality.Alignment" name="Bottom" value="8" />
                  <_x003C_ZOffset_x003E_k__BackingField dataType="Float">100</_x003C_ZOffset_x003E_k__BackingField>
                  <active dataType="Bool">true</active>
                  <gameobj dataType="ObjectRef">2458131936</gameobj>
                  <widgetArea dataType="Struct" type="Duality.Rect">
                    <H dataType="Float">100</H>
                    <W dataType="Float">600</W>
                    <X dataType="Float">0</X>
                    <Y dataType="Float">0</Y>
                  </widgetArea>
                </item>
              </_items>
              <_size dataType="Int">2</_size>
              <_version dataType="Int">4</_version>
            </compList>
            <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="4123556600" surrogate="true">
              <header />
              <body>
                <keys dataType="Array" type="System.Object[]" id="1195475704">
                  <item dataType="ObjectRef">223898436</item>
                  <item dataType="Type" id="4203713388" value="CampGame.UI.UIPanel" />
                </keys>
                <values dataType="Array" type="System.Object[]" id="241016798">
                  <item dataType="ObjectRef">523479572</item>
                  <item dataType="ObjectRef">455882537</item>
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
            <name dataType="String">toolbar</name>
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
                    <X dataType="Float">-410.000031</X>
                    <Y dataType="Float">-494.444458</Y>
                    <Z dataType="Float">0</Z>
                  </pos>
                  <posAbs dataType="Struct" type="Duality.Vector3">
                    <X dataType="Float">-408.888916</X>
                    <Y dataType="Float">-494.444458</Y>
                    <Z dataType="Float">0</Z>
                  </posAbs>
                  <scale dataType="Float">1</scale>
                  <scaleAbs dataType="Float">1</scaleAbs>
                  <vel dataType="Struct" type="Duality.Vector3" />
                  <velAbs dataType="Struct" type="Duality.Vector3" />
                </item>
                <item dataType="Struct" type="CampGame.UI.UICursor" id="748195236">
                  <_x003C_BaseMaterial_x003E_k__BackingField dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Material]]">
                    <contentPath dataType="String">Data\UI\Materials\cursor.Material.res</contentPath>
                  </_x003C_BaseMaterial_x003E_k__BackingField>
                  <_x003C_ZOffset_x003E_k__BackingField dataType="Float">0</_x003C_ZOffset_x003E_k__BackingField>
                  <active dataType="Bool">true</active>
                  <gameobj dataType="ObjectRef">3998162807</gameobj>
                  <widgetArea dataType="Struct" type="Duality.Rect">
                    <H dataType="Float">28</H>
                    <W dataType="Float">20</W>
                    <X dataType="Float">0</X>
                    <Y dataType="Float">0</Y>
                  </widgetArea>
                </item>
              </_items>
              <_size dataType="Int">2</_size>
              <_version dataType="Int">6</_version>
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
        </_items>
        <_size dataType="Int">3</_size>
        <_version dataType="Int">11</_version>
      </children>
      <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="2587341760">
        <_items dataType="Array" type="Duality.Component[]" id="2205635805">
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
          <item dataType="Struct" type="CampGame.UI.UIRenderer" id="3786661655">
            <active dataType="Bool">true</active>
            <gameobj dataType="ObjectRef">1404595237</gameobj>
            <visibilityGroup dataType="Enum" type="Duality.Drawing.VisibilityFlag" name="AllFlags" value="2147483648" />
          </item>
        </_items>
        <_size dataType="Int">4</_size>
        <_version dataType="Int">4</_version>
      </compList>
      <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="3301734517" surrogate="true">
        <header />
        <body>
          <keys dataType="Array" type="System.Object[]" id="2323399860">
            <item dataType="ObjectRef">223898436</item>
            <item dataType="Type" id="39419300" value="CampGame.CameraControl.KeyboardControlComponent" />
            <item dataType="Type" id="1487714070" value="CampGame.UI.UIInputManager" />
            <item dataType="Type" id="3825813664" value="CampGame.UI.UIRenderer" />
          </keys>
          <values dataType="Array" type="System.Object[]" id="2999308278">
            <item dataType="ObjectRef">3764910169</item>
            <item dataType="ObjectRef">897859155</item>
            <item dataType="ObjectRef">1556374447</item>
            <item dataType="ObjectRef">3786661655</item>
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
    <item dataType="Struct" type="Duality.GameObject" id="979997920">
      <active dataType="Bool">false</active>
      <children />
      <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="1026827494">
        <_items dataType="Array" type="Duality.Component[]" id="4268215680" length="4">
          <item dataType="Struct" type="Duality.Components.Transform" id="3340312852">
            <active dataType="Bool">true</active>
            <angle dataType="Float">0</angle>
            <angleAbs dataType="Float">0</angleAbs>
            <angleVel dataType="Float">0</angleVel>
            <angleVelAbs dataType="Float">0</angleVelAbs>
            <deriveAngle dataType="Bool">true</deriveAngle>
            <gameobj dataType="ObjectRef">979997920</gameobj>
            <ignoreParent dataType="Bool">false</ignoreParent>
            <parentTransform />
            <pos dataType="Struct" type="Duality.Vector3">
              <X dataType="Float">2.47934341</X>
              <Y dataType="Float">-66.11571</Y>
              <Z dataType="Float">0</Z>
            </pos>
            <posAbs dataType="Struct" type="Duality.Vector3">
              <X dataType="Float">2.47934341</X>
              <Y dataType="Float">-66.11571</Y>
              <Z dataType="Float">0</Z>
            </posAbs>
            <scale dataType="Float">1</scale>
            <scaleAbs dataType="Float">1</scaleAbs>
            <vel dataType="Struct" type="Duality.Vector3" />
            <velAbs dataType="Struct" type="Duality.Vector3" />
          </item>
          <item dataType="Struct" type="Duality.Components.Renderers.SpriteRenderer" id="2622164488">
            <active dataType="Bool">true</active>
            <colorTint dataType="Struct" type="Duality.Drawing.ColorRgba">
              <A dataType="Byte">255</A>
              <B dataType="Byte">255</B>
              <G dataType="Byte">255</G>
              <R dataType="Byte">255</R>
            </colorTint>
            <customMat />
            <flipMode dataType="Enum" type="Duality.Components.Renderers.SpriteRenderer+FlipMode" name="None" value="0" />
            <gameobj dataType="ObjectRef">979997920</gameobj>
            <offset dataType="Int">0</offset>
            <pixelGrid dataType="Bool">false</pixelGrid>
            <rect dataType="Struct" type="Duality.Rect">
              <H dataType="Float">1040</H>
              <W dataType="Float">1280</W>
              <X dataType="Float">-640</X>
              <Y dataType="Float">-520</Y>
            </rect>
            <rectMode dataType="Enum" type="Duality.Components.Renderers.SpriteRenderer+UVMode" name="Stretch" value="0" />
            <sharedMat dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Material]]">
              <contentPath dataType="String">Data\Map\TheFarm-initial-full.Material.res</contentPath>
            </sharedMat>
            <visibilityGroup dataType="Enum" type="Duality.Drawing.VisibilityFlag" name="Group0" value="1" />
          </item>
        </_items>
        <_size dataType="Int">2</_size>
        <_version dataType="Int">2</_version>
      </compList>
      <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="1389625658" surrogate="true">
        <header />
        <body>
          <keys dataType="Array" type="System.Object[]" id="3368542036">
            <item dataType="ObjectRef">223898436</item>
            <item dataType="Type" id="3270869732" value="Duality.Components.Renderers.SpriteRenderer" />
          </keys>
          <values dataType="Array" type="System.Object[]" id="1071758774">
            <item dataType="ObjectRef">3340312852</item>
            <item dataType="ObjectRef">2622164488</item>
          </values>
        </body>
      </compMap>
      <compTransform dataType="ObjectRef">3340312852</compTransform>
      <identifier dataType="Struct" type="System.Guid" surrogate="true">
        <header>
          <data dataType="Array" type="System.Byte[]" id="2883468400">d9n8ZZUwIU2an29IHmmbtg==</data>
        </header>
        <body />
      </identifier>
      <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
      <name dataType="String">TheFarm-initial-full</name>
      <parent />
      <prefabLink />
    </item>
    <item dataType="ObjectRef">1884001978</item>
    <item dataType="ObjectRef">2458131936</item>
    <item dataType="ObjectRef">3998162807</item>
    <item dataType="ObjectRef">2955533795</item>
  </serializeObj>
  <visibilityStrategy dataType="Struct" type="Duality.Components.DefaultRendererVisibilityStrategy" id="2035693768" />
</root>
<!-- XmlFormatterBase Document Separator -->
