<root dataType="Struct" type="Duality.Resources.Scene" id="129723834">
  <assetInfo />
  <globalGravity dataType="Struct" type="Duality.Vector2">
    <X dataType="Float">0</X>
    <Y dataType="Float">33</Y>
  </globalGravity>
  <serializeObj dataType="Array" type="Duality.GameObject[]" id="427169525">
    <item dataType="Struct" type="Duality.GameObject" id="1986411397">
      <active dataType="Bool">true</active>
      <children dataType="Struct" type="System.Collections.Generic.List`1[[Duality.GameObject]]" id="2348837623">
        <_items dataType="Array" type="Duality.GameObject[]" id="734874254" length="4">
          <item dataType="Struct" type="Duality.GameObject" id="3885967744">
            <active dataType="Bool">true</active>
            <children />
            <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="3276096012">
              <_items dataType="Array" type="Duality.Component[]" id="2441565348" length="4">
                <item dataType="Struct" type="Duality.Components.Transform" id="1951315380">
                  <active dataType="Bool">true</active>
                  <angle dataType="Float">0</angle>
                  <angleAbs dataType="Float">0</angleAbs>
                  <angleVel dataType="Float">0</angleVel>
                  <angleVelAbs dataType="Float">0</angleVelAbs>
                  <deriveAngle dataType="Bool">true</deriveAngle>
                  <gameobj dataType="ObjectRef">3885967744</gameobj>
                  <ignoreParent dataType="Bool">false</ignoreParent>
                  <parentTransform dataType="Struct" type="Duality.Components.Transform" id="51759033">
                    <active dataType="Bool">true</active>
                    <angle dataType="Float">0</angle>
                    <angleAbs dataType="Float">0</angleAbs>
                    <angleVel dataType="Float">0</angleVel>
                    <angleVelAbs dataType="Float">0</angleVelAbs>
                    <deriveAngle dataType="Bool">true</deriveAngle>
                    <gameobj dataType="ObjectRef">1986411397</gameobj>
                    <ignoreParent dataType="Bool">false</ignoreParent>
                    <parentTransform />
                    <pos dataType="Struct" type="Duality.Vector3">
                      <X dataType="Float">0</X>
                      <Y dataType="Float">0</Y>
                      <Z dataType="Float">-100</Z>
                    </pos>
                    <posAbs dataType="Struct" type="Duality.Vector3">
                      <X dataType="Float">0</X>
                      <Y dataType="Float">0</Y>
                      <Z dataType="Float">-100</Z>
                    </posAbs>
                    <scale dataType="Float">1</scale>
                    <scaleAbs dataType="Float">1</scaleAbs>
                    <vel dataType="Struct" type="Duality.Vector3" />
                    <velAbs dataType="Struct" type="Duality.Vector3" />
                  </parentTransform>
                  <pos dataType="Struct" type="Duality.Vector3">
                    <X dataType="Float">0</X>
                    <Y dataType="Float">0</Y>
                    <Z dataType="Float">50</Z>
                  </pos>
                  <posAbs dataType="Struct" type="Duality.Vector3">
                    <X dataType="Float">0</X>
                    <Y dataType="Float">0</Y>
                    <Z dataType="Float">-50</Z>
                  </posAbs>
                  <scale dataType="Float">1</scale>
                  <scaleAbs dataType="Float">1</scaleAbs>
                  <vel dataType="Struct" type="Duality.Vector3" />
                  <velAbs dataType="Struct" type="Duality.Vector3" />
                </item>
                <item dataType="Struct" type="Duality.Components.Renderers.SpriteRenderer" id="1233167016">
                  <active dataType="Bool">true</active>
                  <colorTint dataType="Struct" type="Duality.Drawing.ColorRgba">
                    <A dataType="Byte">255</A>
                    <B dataType="Byte">255</B>
                    <G dataType="Byte">255</G>
                    <R dataType="Byte">255</R>
                  </colorTint>
                  <customMat />
                  <flipMode dataType="Enum" type="Duality.Components.Renderers.SpriteRenderer+FlipMode" name="None" value="0" />
                  <gameobj dataType="ObjectRef">3885967744</gameobj>
                  <offset dataType="Int">0</offset>
                  <pixelGrid dataType="Bool">false</pixelGrid>
                  <rect dataType="Struct" type="Duality.Rect">
                    <H dataType="Float">28</H>
                    <W dataType="Float">20</W>
                    <X dataType="Float">-10</X>
                    <Y dataType="Float">-14</Y>
                  </rect>
                  <rectMode dataType="Enum" type="Duality.Components.Renderers.SpriteRenderer+UVMode" name="Stretch" value="0" />
                  <sharedMat dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Material]]">
                    <contentPath dataType="String">Data\UI\Materials\cursor.Material.res</contentPath>
                  </sharedMat>
                  <visibilityGroup dataType="Enum" type="Duality.Drawing.VisibilityFlag" name="Group0" value="1" />
                </item>
                <item dataType="Struct" type="CampGame.CursorLogic" id="2719020653">
                  <_x003C_Camera_x003E_k__BackingField />
                  <active dataType="Bool">true</active>
                  <gameobj dataType="ObjectRef">3885967744</gameobj>
                </item>
              </_items>
              <_size dataType="Int">3</_size>
              <_version dataType="Int">3</_version>
            </compList>
            <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="2430640886" surrogate="true">
              <header />
              <body>
                <keys dataType="Array" type="System.Object[]" id="4073972358">
                  <item dataType="Type" id="2837340032" value="Duality.Components.Transform" />
                  <item dataType="Type" id="1254999246" value="Duality.Components.Renderers.SpriteRenderer" />
                  <item dataType="Type" id="332931356" value="CampGame.CursorLogic" />
                </keys>
                <values dataType="Array" type="System.Object[]" id="796573498">
                  <item dataType="ObjectRef">1951315380</item>
                  <item dataType="ObjectRef">1233167016</item>
                  <item dataType="ObjectRef">2719020653</item>
                </values>
              </body>
            </compMap>
            <compTransform dataType="ObjectRef">1951315380</compTransform>
            <identifier dataType="Struct" type="System.Guid" surrogate="true">
              <header>
                <data dataType="Array" type="System.Byte[]" id="2533398022">y2ouNbEnsEOZA/UPW/KH+w==</data>
              </header>
              <body />
            </identifier>
            <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
            <name dataType="String">Cursor</name>
            <parent dataType="ObjectRef">1986411397</parent>
            <prefabLink />
          </item>
          <item dataType="Struct" type="Duality.GameObject" id="2540312231">
            <active dataType="Bool">true</active>
            <children />
            <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="3380971095">
              <_items dataType="Array" type="Duality.Component[]" id="4207072782" length="4">
                <item dataType="Struct" type="Duality.Components.Transform" id="605659867">
                  <active dataType="Bool">true</active>
                  <angle dataType="Float">0</angle>
                  <angleAbs dataType="Float">0</angleAbs>
                  <angleVel dataType="Float">0</angleVel>
                  <angleVelAbs dataType="Float">0</angleVelAbs>
                  <deriveAngle dataType="Bool">true</deriveAngle>
                  <gameobj dataType="ObjectRef">2540312231</gameobj>
                  <ignoreParent dataType="Bool">false</ignoreParent>
                  <parentTransform dataType="ObjectRef">51759033</parentTransform>
                  <pos dataType="Struct" type="Duality.Vector3">
                    <X dataType="Float">0</X>
                    <Y dataType="Float">0</Y>
                    <Z dataType="Float">-400</Z>
                  </pos>
                  <posAbs dataType="Struct" type="Duality.Vector3">
                    <X dataType="Float">0</X>
                    <Y dataType="Float">0</Y>
                    <Z dataType="Float">-500</Z>
                  </posAbs>
                  <scale dataType="Float">1</scale>
                  <scaleAbs dataType="Float">1</scaleAbs>
                  <vel dataType="Struct" type="Duality.Vector3" />
                  <velAbs dataType="Struct" type="Duality.Vector3" />
                </item>
                <item dataType="Struct" type="Duality.Components.Camera" id="3077588038">
                  <active dataType="Bool">true</active>
                  <farZ dataType="Float">10000</farZ>
                  <focusDist dataType="Float">500</focusDist>
                  <gameobj dataType="ObjectRef">2540312231</gameobj>
                  <nearZ dataType="Float">0</nearZ>
                  <passes dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Components.Camera+Pass]]" id="1772379642">
                    <_items dataType="Array" type="Duality.Components.Camera+Pass[]" id="3588928896" length="4">
                      <item dataType="Struct" type="Duality.Components.Camera+Pass" id="3060688284">
                        <clearColor dataType="Struct" type="Duality.Drawing.ColorRgba" />
                        <clearDepth dataType="Float">1</clearDepth>
                        <clearFlags dataType="Enum" type="Duality.Drawing.ClearFlag" name="All" value="3" />
                        <input />
                        <matrixMode dataType="Enum" type="Duality.Drawing.RenderMatrix" name="PerspectiveWorld" value="0" />
                        <output dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.RenderTarget]]" />
                        <visibilityMask dataType="Enum" type="Duality.Drawing.VisibilityFlag" name="AllGroups" value="2147483647" />
                      </item>
                      <item dataType="Struct" type="Duality.Components.Camera+Pass" id="4256286742">
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
            <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="3974119360" surrogate="true">
              <header />
              <body>
                <keys dataType="Array" type="System.Object[]" id="2166903517">
                  <item dataType="ObjectRef">2837340032</item>
                  <item dataType="Type" id="216158310" value="Duality.Components.Camera" />
                </keys>
                <values dataType="Array" type="System.Object[]" id="20097144">
                  <item dataType="ObjectRef">605659867</item>
                  <item dataType="ObjectRef">3077588038</item>
                </values>
              </body>
            </compMap>
            <compTransform dataType="ObjectRef">605659867</compTransform>
            <identifier dataType="Struct" type="System.Guid" surrogate="true">
              <header>
                <data dataType="Array" type="System.Byte[]" id="4000055927">71ckTE4PvUGTEtSID73b9Q==</data>
              </header>
              <body />
            </identifier>
            <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
            <name dataType="String">MainCamera</name>
            <parent dataType="ObjectRef">1986411397</parent>
            <prefabLink />
          </item>
          <item dataType="Struct" type="Duality.GameObject" id="135115470">
            <active dataType="Bool">true</active>
            <children />
            <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="3359513026">
              <_items dataType="Array" type="Duality.Component[]" id="3261940240" length="0" />
              <_size dataType="Int">0</_size>
              <_version dataType="Int">0</_version>
            </compList>
            <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="1221087754" surrogate="true">
              <header />
              <body>
                <keys dataType="Array" type="System.Object[]" id="4033238936" length="0" />
                <values dataType="Array" type="System.Object[]" id="2046094110" length="0" />
              </body>
            </compMap>
            <compTransform />
            <identifier dataType="Struct" type="System.Guid" surrogate="true">
              <header>
                <data dataType="Array" type="System.Byte[]" id="2272611268">p/i/V7IMgUq1vFMXcACK6A==</data>
              </header>
              <body />
            </identifier>
            <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
            <name dataType="String">MenuBar</name>
            <parent dataType="ObjectRef">1986411397</parent>
            <prefabLink />
          </item>
        </_items>
        <_size dataType="Int">3</_size>
        <_version dataType="Int">11</_version>
      </children>
      <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="3860510272">
        <_items dataType="Array" type="Duality.Component[]" id="1775490621" length="4">
          <item dataType="ObjectRef">51759033</item>
          <item dataType="Struct" type="CampGame.CameraControl.KeyboardControlComponent" id="1479675315">
            <_x003C_CrosshairSize_x003E_k__BackingField dataType="Float">32</_x003C_CrosshairSize_x003E_k__BackingField>
            <_x003C_ShowPosition_x003E_k__BackingField dataType="Bool">false</_x003C_ShowPosition_x003E_k__BackingField>
            <_x003C_Speed_x003E_k__BackingField dataType="Float">10</_x003C_Speed_x003E_k__BackingField>
            <active dataType="Bool">true</active>
            <gameobj dataType="ObjectRef">1986411397</gameobj>
          </item>
        </_items>
        <_size dataType="Int">2</_size>
        <_version dataType="Int">2</_version>
      </compList>
      <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="2179827541" surrogate="true">
        <header />
        <body>
          <keys dataType="Array" type="System.Object[]" id="3380770996">
            <item dataType="ObjectRef">2837340032</item>
            <item dataType="Type" id="2179378596" value="CampGame.CameraControl.KeyboardControlComponent" />
          </keys>
          <values dataType="Array" type="System.Object[]" id="3070353398">
            <item dataType="ObjectRef">51759033</item>
            <item dataType="ObjectRef">1479675315</item>
          </values>
        </body>
      </compMap>
      <compTransform dataType="ObjectRef">51759033</compTransform>
      <identifier dataType="Struct" type="System.Guid" surrogate="true">
        <header>
          <data dataType="Array" type="System.Byte[]" id="1205106448">4XJe/zhgrEmo6+muSDJzyA==</data>
        </header>
        <body />
      </identifier>
      <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
      <name dataType="String">UI</name>
      <parent />
      <prefabLink />
    </item>
    <item dataType="Struct" type="Duality.GameObject" id="2292067584">
      <active dataType="Bool">true</active>
      <children />
      <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="244074054">
        <_items dataType="Array" type="Duality.Component[]" id="2000250880" length="4">
          <item dataType="Struct" type="CampGame.GameTimeComponent" id="3489437169">
            <active dataType="Bool">true</active>
            <gameobj dataType="ObjectRef">2292067584</gameobj>
            <inGameTime dataType="Struct" type="System.DateTime">
              <dateData dataType="ULong">636019992000000000</dateData>
            </inGameTime>
          </item>
        </_items>
        <_size dataType="Int">1</_size>
        <_version dataType="Int">1</_version>
      </compList>
      <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="3369768378" surrogate="true">
        <header />
        <body>
          <keys dataType="Array" type="System.Object[]" id="4016227764">
            <item dataType="Type" id="933705636" value="CampGame.GameTimeComponent" />
          </keys>
          <values dataType="Array" type="System.Object[]" id="4283248118">
            <item dataType="ObjectRef">3489437169</item>
          </values>
        </body>
      </compMap>
      <compTransform />
      <identifier dataType="Struct" type="System.Guid" surrogate="true">
        <header>
          <data dataType="Array" type="System.Byte[]" id="520687120">Am2dPANyokCIbsbXZaXzoA==</data>
        </header>
        <body />
      </identifier>
      <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
      <name dataType="String">GameTime</name>
      <parent />
      <prefabLink />
    </item>
    <item dataType="ObjectRef">3885967744</item>
    <item dataType="ObjectRef">2540312231</item>
    <item dataType="ObjectRef">135115470</item>
  </serializeObj>
  <visibilityStrategy dataType="Struct" type="Duality.Components.DefaultRendererVisibilityStrategy" id="2035693768" />
</root>
<!-- XmlFormatterBase Document Separator -->
